using AutoMapper;
using FilmMoi.Application.DataTransferObj.Genres;
using FilmMoi.Application.Interface.ReadOnly;
using FilmMoi.Application.Interface.ReadWrite;
using FilmMoi.Domain.Models.Entities;
using FilmMoi.Infrastracture.Implement.Repository.ReadOnly;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmMoi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenresReadOnlyRepository _repoRead;
        private readonly IReadWriteRepository<Genres> _repoWrite;
        public readonly IMapper _mapper;

        public GenresController(IGenresReadOnlyRepository repo, IMapper mapper, IReadWriteRepository<Genres> repoWrite)
        {
            _repoRead = repo;
            _mapper = mapper;
            _repoWrite = repoWrite;
        }

        [HttpGet("name")]
        public async Task<IActionResult> GetAll(string? name, CancellationToken cancellationToken)
        {
            try
            {
                var lst = await _repoRead.GetAllAsync(name, cancellationToken);
                return Ok(lst);
            }
            catch (Exception ex) 
            {
                return BadRequest("Faild: " + $"{ex.Message }");
            }
        }


        [HttpGet("id")]
        public async Task<IActionResult> GetById(string? id, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _repoRead.GetByIdAsync(id, cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(GenreCreateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _repoWrite.Create(_mapper.Map<Genres>(request), cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }


        [HttpDelete]
        public async Task<IActionResult> Delete(GenreDeleteRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _repoWrite.Delete(request.Id,_mapper.Map<Genres>(request), cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }
    }
}
