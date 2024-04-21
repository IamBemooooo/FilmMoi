using AutoMapper;
using FilmMoi.Application.DataTransferObj.Actors;
using FilmMoi.Application.DataTransferObj.Comments;
using FilmMoi.Application.Interface.ReadOnly;
using FilmMoi.Application.Interface.ReadWrite;
using FilmMoi.Domain.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmMoi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IReadOnlyWPRepository<CommentDto,CommentWithPaginationRequest> _repoRead;
        private readonly IReadWriteRepository<Comments> _repoWrite;
        public readonly IMapper _mapper;
        public CommentsController(IReadOnlyWPRepository<CommentDto, CommentWithPaginationRequest> repo, IMapper mapper, IReadWriteRepository<Comments> repoWrite)
        {
            _repoRead = repo;
            _mapper = mapper;
            _repoWrite = repoWrite;
        }
        [HttpGet("All/id")]
        public async Task<IActionResult> Get([FromQuery] CommentWithPaginationRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _repoRead.GetAll(request, cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CommentCreateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _repoWrite.Create(_mapper.Map<Comments>(request), cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(CommentDeleteRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _repoWrite.Delete(request.ID, _mapper.Map<Comments>(request), cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(CommentUpdateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _repoWrite.Update(request.ID, _mapper.Map<Comments>(request), cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest("Faild: " + $"{ex.Message}");
            }
        }
    }
}
