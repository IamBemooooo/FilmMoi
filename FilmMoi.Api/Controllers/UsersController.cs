using AutoMapper;
using FilmMoi.Application.DataTransferObj.Users;
using FilmMoi.Application.Interface.ReadOnly;
using FilmMoi.Application.Interface.ReadWrite;
using FilmMoi.Domain.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmMoi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IReadOnlyWPRepository<UserDto, UsersWithPaginationRequest> _repoOnly;
        private readonly IReadWriteRepository<Users> _repoWrite;
        private readonly IMapper _map;

        public UsersController(IReadOnlyWPRepository<UserDto, UsersWithPaginationRequest> repoOnly, IReadWriteRepository<Users> repoWrite, IMapper map)
        {
            _repoOnly = repoOnly;
            _repoWrite = repoWrite;
            _map = map;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]UsersWithPaginationRequest request,CancellationToken cancellationToken)
        {
            var result = await _repoOnly.GetAll(request, cancellationToken);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]UsersCreateRequest request,CancellationToken cancellationToken)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(request.IsValid()))
                {
                    var result = await _repoWrite.Create(_map.Map<Users>(request), cancellationToken);
                    return Ok($"Success");
                }
                return BadRequest(request.IsValid());
            }
            catch (Exception ex)
            { 
                return BadRequest(ex.Message);
            }
        }
    }
}
