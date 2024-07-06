using FilmMoi.Application.DataTransferObj.Users.Utilities;
using FilmMoi.Application.ValueObj.Extentions;
using FilmMoi.Domain.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FilmMoi.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]

	public class LoginController : ControllerBase
	{
		private readonly UserManager<Users> _userManager;
		private readonly SignInManager<Users> _signManager;
		private readonly IConfiguration _configuration;

		public LoginController(UserManager<Users> userManager, SignInManager<Users> signManager, IConfiguration configuration)
		{
			_userManager = userManager;
			_signManager = signManager;
			_configuration = configuration;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return Ok("Login");
		}

		[HttpPost]
		public async Task<IActionResult> Login(string username,string password)
		{
            
            var user = await _userManager.FindByNameAsync(username);
			Console.WriteLine(user);
			var rs = true ? (user.PasswordHash == Hash.EncryptPassword(password)) : false;
			if (user != null && rs)
			{

				var userClaims = await _userManager.GetClaimsAsync(user);
				var roles = await _userManager.GetRolesAsync(user);
				await _signManager.SignInAsync(user, false);
				var claims = new List<Claim>
			{
				new Claim(ClaimTypes.Name, username),
			};

				claims.AddRange(userClaims);
				claims.AddRange(roles.Select(r => new Claim(ClaimTypes.Role, r)));

				var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
				var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
				var expires = DateTime.Now.AddDays(Convert.ToDouble(_configuration["Jwt:ExpirationInDays"]));

				var token = new JwtSecurityToken(
					_configuration["Jwt:Issuer"],
					_configuration["Jwt:Audience"],
					claims,
					expires: expires,
					signingCredentials: creds
				);

				return Ok(new
				{
					token = new JwtSecurityTokenHandler().WriteToken(token),
					expiration = expires
				});
			}

			return Unauthorized();
		}
	}
}
