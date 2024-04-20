using AutoMapper;
using FilmMoi.Application.DataTransferObj.FilmActors;
using FilmMoi.Application.DataTransferObj.GenreFilm;
using FilmMoi.Application.Interface.ReadWrite;
using FilmMoi.Domain.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmMoi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreFilmsController : ControllerBase
    {
        private readonly IReadWriteRepository<GenreFilms> _repoWrite;
        public readonly IMapper _mapper;
        public GenreFilmsController(IMapper mapper, IReadWriteRepository<GenreFilms> repoWrite)
        {
            _mapper = mapper;
            _repoWrite = repoWrite;
        }

        [HttpPost]
        public async Task<IActionResult> Create(GenreFilmCreateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _repoWrite.Create(_mapper.Map<GenreFilms>(request), cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }


        [HttpDelete]
        public async Task<IActionResult> Delete(GenreFilmDeteleRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _repoWrite.Delete(request.ID_Genre, _mapper.Map<GenreFilms>(request), cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }
    }
}
