using FilmMoi.Application.DataTransferObj.Episodes;
using FilmMoi.Application.Interface.ReadOnly;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmMoi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpisodesController : ControllerBase
    {
        private readonly IReadOnlyWPRepository<EpisodesDto, EpisodesWithPaginationRequest> _repoOnly;

        public EpisodesController(IReadOnlyWPRepository<EpisodesDto, EpisodesWithPaginationRequest> repoOnly)
        {
            _repoOnly = repoOnly;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]EpisodesWithPaginationRequest request, CancellationToken cancellationToken)
        {
            var result = await _repoOnly.GetAll(request, cancellationToken);
            return Ok(result);
        }
    }
}
