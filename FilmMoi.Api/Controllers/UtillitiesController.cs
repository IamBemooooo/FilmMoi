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

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]ForgotPasswordRequest request,CancellationToken cancellationToken)
        {
            var result = await _repo.SeedGmail(request.Email);
            return Ok(result);
        }
    }
}
