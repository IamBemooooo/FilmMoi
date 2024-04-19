using AutoMapper;
using FilmMoi.Application.DataTransferObj.Actors;
using FilmMoi.Application.DataTransferObj.Genres;
using FilmMoi.Application.Interface.ReadOnly;
using FilmMoi.Application.Interface.ReadWrite;
using FilmMoi.Domain.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FilmMoi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private readonly IActorsReadOnlyRepository _repoRead;
        private readonly IReadWriteRepository<Actors> _repoWrite;
        public readonly IMapper _mapper;
        public ActorsController(IActorsReadOnlyRepository repo, IMapper mapper, IReadWriteRepository<Actors> repoWrite)
        {
            _repoRead = repo;
            _mapper = mapper;
            _repoWrite = repoWrite;
        }

        [HttpGet("name")]
        public async Task<IActionResult> GetAll([FromQuery]ActorWithPaginationRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var lst = await _repoRead.GetActorWithPaginationRequest(request, cancellationToken);
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }


        [HttpGet("id")]
        public async Task<IActionResult> GetById(string? id, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _repoRead.GetById(Guid.Parse(id), cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(ActorCreateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _repoWrite.Create(_mapper.Map<Actors>(request), cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }


        [HttpDelete]
        public async Task<IActionResult> Delete(ActorDeleteRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _repoWrite.Delete(request.Id, _mapper.Map<Actors>(request), cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(ActorUpdateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _repoWrite.Update(request.ID, _mapper.Map<Actors>(request), cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }
    }
}
