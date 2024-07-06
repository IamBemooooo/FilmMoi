using AutoMapper;
using FilmMoi.Application.DataTransferObj.Films;
using FilmMoi.Application.DataTransferObj.Ratings;
using FilmMoi.Application.Interface.ReadOnly;
using FilmMoi.Application.Interface.ReadWrite;
using FilmMoi.Domain.Models.Entities;
using FilmMoi.Infrastructure.Implement.Repository.ReadOnly;
using FilmMoi.Infrastructure.Implement.Repository.ReadWrite;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmMoi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
        private readonly IReadWriteRepository<Films> _repoWrite;
        private readonly IReadOnlyNPRepository<RatingDto> _rating;
        private readonly FilmsReadOnlyRepository _repoOnly;
        private readonly IMapper _map;
        public FilmsController(IMapper map, IReadOnlyNPRepository<RatingDto> rating)
        {
            _rating = rating;
            _repoWrite = new FilmsReadWriteRepository(map);
            _repoOnly = new FilmsReadOnlyRepository(map,_rating);
            _map = map;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]FilmsWithPaginationRequest request, CancellationToken cancellationToken)
        {
            try
            {
               var result = await _repoOnly.GetAll(request, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Fail: {ex}");
            }
        } 
        [HttpGet("id")]
        public async Task<IActionResult> Get(Guid id, CancellationToken cancellationToken)
        {
            try
            {
               var result = await _repoOnly.GetById(id, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Fail: {ex}");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post(FilmsCreateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                await _repoWrite.Create(_map.Map<Films>(request), cancellationToken);
                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest($"Fail: {ex}");
            }
        } 
        [HttpDelete]
        public async Task<IActionResult> Delete(FilmsDeleteRequest request, CancellationToken cancellationToken)
        {
            try
            {
                await _repoWrite.Delete(request.Id,_map.Map<Films>(request), cancellationToken);
                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest($"Fail: {ex}");
            }

        }
        [HttpPut]
        public async Task<IActionResult> Put(Guid id, FilmsUpdateRequest request,CancellationToken cancellationToken)
        {
            try
            {
                await _repoWrite.Update(id,_map.Map<Films>(request), cancellationToken);
                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest($"Fail: {ex}");
            }

        }
    }
}
