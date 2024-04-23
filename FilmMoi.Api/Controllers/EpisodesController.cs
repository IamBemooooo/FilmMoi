using AutoMapper;
using FilmMoi.Application.DataTransferObj.Episodes;
using FilmMoi.Application.Interface.ReadOnly;
using FilmMoi.Application.Interface.ReadWrite;
using FilmMoi.Domain.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmMoi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpisodesController : ControllerBase
    {
        private readonly IReadOnlyWPRepository<EpisodesDto, EpisodesWithPaginationRequest> _repoOnly;
        private readonly IReadWriteRepository<Episodes> _repoWrite;
        private readonly IMapper _map;


        public EpisodesController(IReadOnlyWPRepository<EpisodesDto, EpisodesWithPaginationRequest> repoOnly, IReadWriteRepository<Episodes> repoWrite ,IMapper map)
        {
            _repoOnly = repoOnly;
            _repoWrite = repoWrite;
            _map = map;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]EpisodesWithPaginationRequest request, CancellationToken cancellationToken)
        {
            var result = await _repoOnly.GetAll(request, cancellationToken);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]EpisodesCreateRequest request, CancellationToken cancellationToken)
        {
            var result = await _repoWrite.Create(_map.Map<Episodes>(request), cancellationToken);
            return Ok(result);
        }  [HttpPut]
        public async Task<IActionResult> Put(Guid id, [FromBody]EpisodesUpdateRequest request, CancellationToken cancellationToken)
        {
            var result = await _repoWrite.Update(id,_map.Map<Episodes>(request), cancellationToken);
            return Ok(result);
        }  
        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
        {
            var result = await _repoWrite.Delete(id,null, cancellationToken);
            return Ok(result);
        }
    }
}
