using AutoMapper;
using FilmMoi.Application.Interface.ReadWrite;
using FilmMoi.Domain.Models;
using FilmMoi.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Infrastracture.Implement.Repository.ReadWrite
{
    public class ActorsReadWriteRepository : IReadWriteRepository<Actors>
    {
        private FilmMoiContext _context;
        public IMapper _mapper;
        public ActorsReadWriteRepository(FilmMoiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> Create(Actors data, CancellationToken cancellationToken)
        {
            try
            {
                data.CreatedTime = DateTime.UtcNow;
                _context.Actors.Add(data);
                _context.SaveChanges();
                return await Task.FromResult(true);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }

        public async Task<bool> Delete(Guid id, Actors? data, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await GetById(id);
                obj.Deleted = true;
                obj.DeletedBy = data.DeletedBy;
                obj.DeletedTime = DateTime.UtcNow;
                _context.Actors.Update(obj);
                await _context.SaveChangesAsync();
                return await Task.FromResult(true);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }

        public async Task<bool> Update(Guid id, Actors data, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await GetById(id);
                obj.ModifiedTime = DateTime.UtcNow;
                _mapper.Map(data, obj);
                _context.Actors.Update(obj);
                await _context.SaveChangesAsync();
                return await Task.FromResult(true);
                /* var obj = await GetById(id);
                 *//* obj.GenreName = string.IsNullOrEmpty(data.GenreName) ? obj.GenreName : data.GenreName;*//*
                 obj.ModifiedTime = DateTime.UtcNow;
                 obj.ModifiedBy = data.ModifiedBy;
                 _context.Actors.Update(obj);
                 await _context.SaveChangesAsync();
                 return await Task.FromResult(true);*/
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }

        private async Task<Actors> GetById(Guid id)
        {
            var obj = await _context.Actors.FindAsync(id);
            return obj;
        }
    }
}
