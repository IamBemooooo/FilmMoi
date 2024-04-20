using AutoMapper;
using FilmMoi.Application.DataTransferObj.Actors;
using FilmMoi.Application.DataTransferObj.FilmActors;
using FilmMoi.Application.Interface.ReadWrite;
using FilmMoi.Domain.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FilmMoi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmActorsController : ControllerBase
    {
        private readonly IReadWriteRepository<FilmActors> _repoWrite;
        public readonly IMapper _mapper;
        public FilmActorsController(IMapper mapper, IReadWriteRepository<FilmActors> repoWrite)
        {
            _mapper = mapper;
            _repoWrite = repoWrite;
        }

        [HttpPost]
        public async Task<IActionResult> Create(FilmActorCreateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _repoWrite.Create(_mapper.Map<FilmActors>(request), cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }


        [HttpDelete]
        public async Task<IActionResult> Delete(FilmActorDeleteRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _repoWrite.Delete(request.ID_ACtor, _mapper.Map<FilmActors>(request), cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }
    }
}
