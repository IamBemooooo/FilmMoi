using FilmMoi.Application.DataTransferObj.Users.Utilities;
using FilmMoi.Application.Interface.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmMoi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtillitiesController : ControllerBase
    {
        private readonly IUsersUtilitiesRepository _repo;

        public UtillitiesController(IUsersUtilitiesRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("seedgmail")]
        public async Task<IActionResult> SeedMail(SeedMailRequest request)
        {
            try
            {
                var obj = await _repo.SeedGmail(request);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }

        [HttpPut("forgotpassword")]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _repo.ForgotPassword(request, cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }

        [HttpPut("changepassword")]
        public async Task<IActionResult> ChangePassword(ChangePasswordRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _repo.ChangePassword(request, cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }
    }
}
