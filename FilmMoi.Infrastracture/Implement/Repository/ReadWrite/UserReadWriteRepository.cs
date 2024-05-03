using AutoMapper;
using FilmMoi.Application.Interface.ReadWrite;
using FilmMoi.Application.ValueObj.Extentions;
using FilmMoi.Domain.Models;
using FilmMoi.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Infrastracture.Implement.Repository.ReadWrite
{
    public class UserReadWriteRepository : IReadWriteRepository<Users>
    {
        private readonly FlimMoiContext _db;
        private readonly IMapper _mapper;

        public UserReadWriteRepository(IMapper mapper)
        {
            _db = new FlimMoiContext();
            _mapper = mapper;
        }

        public async Task<bool> Create(Users data, CancellationToken cancellationToken)
        {
            try
            {
                data.NormalizedUserName = data.UserName.ToUpperInvariant();
                data.NormalizedEmail = data.Email.ToUpperInvariant();
                data.PasswordHash = Hash.EncryptPassword(data.PasswordHash);
                data.SecurityStamp = Guid.NewGuid().ToString();
                data.CreatedTime = DateTimeOffset.UtcNow;
                data.ConcurrencyStamp = Guid.NewGuid().ToString();
                data.RoleId = Guid.Parse("a040eef1-1d71-437e-ac64-e94d0b65c856");
                await _db.Users.AddAsync(data);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Task<bool> Delete(Guid id, Users? data, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(Guid id, Users data, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await GetById(id,cancellationToken);
                _mapper.Map(data,obj);
                obj.NormalizedUserName = data.UserName.ToUpperInvariant();
                obj.NormalizedEmail = data.Email.ToUpperInvariant();
                _db.Users.Update(obj);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private async Task<Users?> GetById(Guid id, CancellationToken cancellationToken)
        {
            var obj = await _db.Users.FirstOrDefaultAsync(x => x.Id == id && !x.LockoutEnabled);
            return obj;
        }

    }
}
