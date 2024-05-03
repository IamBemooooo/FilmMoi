using AutoMapper;
using FilmMoi.Application.DataTransferObj.Genres;
using FilmMoi.Application.DataTransferObj.WatchedFilms;
using FilmMoi.Application.Interface.ReadOnly;
using FilmMoi.Application.Interface.ReadWrite;
using FilmMoi.Domain.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmMoi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WatchedFilmsController : ControllerBase
    {
        private readonly IReadOnlyNPRepository<WatchedFilmDto> _repoRead;
        private readonly IReadWriteRepository<WatchedFilms> _repoWrite;
        public readonly IMapper _mapper;

        public WatchedFilmsController(IReadOnlyNPRepository<WatchedFilmDto> repo, IMapper mapper, IReadWriteRepository<WatchedFilms> repoWrite)
        {
            _repoRead = repo;
            _mapper = mapper;
            _repoWrite = repoWrite;
        }

        [HttpGet("name")]
        public async Task<IActionResult> GetAll(string? name, Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var lst = await _repoRead.GetAllAsync(name, id, cancellationToken);
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]WatchedFilmCreateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _repoWrite.Create(_mapper.Map<WatchedFilms>(request), cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }


        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody]WatchedFilmDeleteRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _repoWrite.Delete(request.ID, _mapper.Map<WatchedFilms>(request), cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }
    }
}
