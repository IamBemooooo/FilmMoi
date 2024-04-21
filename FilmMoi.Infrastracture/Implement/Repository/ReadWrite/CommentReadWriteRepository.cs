using AutoMapper;
using FilmMoi.Application.Interface.ReadWrite;
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
    public class CommentReadWriteRepository : IReadWriteRepository<Comments>
    {
        private FlimMoiContext _context;
        public IMapper _mapper;
        public CommentReadWriteRepository(FlimMoiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> Create(Comments data, CancellationToken cancellationToken)
        {
            try
            {
                data.CreatedTime = DateTime.UtcNow;
                _context.Comments.Add(data);
                _context.SaveChanges();
                return await Task.FromResult(true);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }

        public async Task<bool> Delete(Guid id, Comments? data, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await GetById(id);
               
                _context.Comments.Remove(obj);
                await _context.SaveChangesAsync();
                return await Task.FromResult(true);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }

        public async Task<bool> Update(Guid id, Comments data, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await GetById(id);
                obj.ModifiedTime = DateTime.UtcNow;
                _mapper.Map(data, obj);
                _context.Comments.Update(obj);
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

        private async Task<Comments> GetById(Guid id)
        {
            var obj = await _context.Comments.FindAsync(id);
            return obj;
        }
    }
}
