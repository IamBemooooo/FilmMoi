using AutoMapper;
using FilmMoi.Application.DataTransferObj.Users;
using FilmMoi.Application.Interface.ReadOnly;
using FilmMoi.Application.ValueObj.Extentions;
using FilmMoi.Application.ValueObj.Pagination;
using FilmMoi.Domain.Models;
using FilmMoi.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Infrastracture.Implement.Repository.ReadOnly
{
    public class UserReadOnlyRepository : IReadOnlyWPRepository<UserDto, UsersWithPaginationRequest>
    {
        private readonly FlimMoiContext _db;
        private readonly IMapper _map;

        public UserReadOnlyRepository(IMapper map)
        {
            _db = new FlimMoiContext();
            _map = map;
        }

        public async Task<PaginationResponse<UserDto>> GetAll(UsersWithPaginationRequest request, CancellationToken cancellationToken)
        {
            var query = _db.Users.AsNoTracking();
            if (!string.IsNullOrWhiteSpace(request.UserName))
            {
               query = query.Where(x => x.UserName.Contains(request.UserName));
            }
            var result = await query.PaginateAsync<Users,UserDto>(request,_map, cancellationToken);
            result.Data =await (from item in query
                           select new UserDto
                           {
                               UserName = item.UserName,
                               Email = item.Email,                
                               LockoutEnabled = item.LockoutEnabled,
                               PasswordHash = item.PasswordHash,
                               PhoneNumber = item.PhoneNumber
                           }).ToListAsync();
            return new PaginationResponse<UserDto>()
            {
                Data = result.Data,
                HasNext = result.HasNext,
                PageNumber = result.PageNumber,
                PageSize = result.PageSize
            };

        }

        public Task<UserDto> GetById(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
