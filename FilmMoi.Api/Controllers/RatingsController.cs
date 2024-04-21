using AutoMapper;
using FilmMoi.Application.DataTransferObj.Actors;
using FilmMoi.Application.DataTransferObj.Ratings;
using FilmMoi.Application.Interface.ReadOnly;
using FilmMoi.Application.Interface.ReadWrite;
using FilmMoi.Domain.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmMoi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        private readonly IReadOnlyNPRepository<RatingDto> _readOnly;
        public readonly IReadWriteRepository<Ratings> _ReadWrite;
        public readonly IMapper _mapper;
        public RatingsController(IReadOnlyNPRepository<RatingDto> readOnly, IMapper mapper, IReadWriteRepository<Ratings> ReadWrite)
        {
            _mapper = mapper;
            _readOnly = readOnly;
            _ReadWrite = ReadWrite;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(Guid id,CancellationToken cancellationToken) 
        {
            try
            {
                var lst = await _readOnly.GetAllAsync("",id,cancellationToken);
                return Ok(lst);
            }
            catch (Exception ex) 
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(RatingCreateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _ReadWrite.Create(_mapper.Map<Ratings>(request), cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }


        [HttpDelete]
        public async Task<IActionResult> Delete(RatingDeleteRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _ReadWrite.Delete(request.ID_User, _mapper.Map<Ratings>(request), cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(RatingUpdateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _ReadWrite.Update(request.ID_User, _mapper.Map<Ratings>(request), cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }
    }
}
