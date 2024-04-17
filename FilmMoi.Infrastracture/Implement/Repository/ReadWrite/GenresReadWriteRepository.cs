using AutoMapper;
using Azure.Core;
using FilmMoi.Application.DataTransferObj.Genres;
using FilmMoi.Application.Interface.ReadWrite;
using FilmMoi.Domain.Models;
using FilmMoi.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FilmMoi.Infrastracture.Implement.Repository.ReadWrite
{
    public class GenresReadWriteRepository : IReadWriteRepository<Genres>
    {
        private FlimMoiContext _context;
        public IMapper _mapper;
        public GenresReadWriteRepository(FlimMoiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> Create(Genres data, CancellationToken cancellationToken)
        {
            try
            {
                data.CreatedTime = DateTime.UtcNow;
                _context.Genres.Add(data);
                _context.SaveChanges();
                return await Task.FromResult(true);
            }
            catch 
            {
                return await Task.FromResult(false);
            }

        }


        public async Task<bool> Update(Guid id, Genres data, CancellationToken cancellationToken)
        {
            try
            {
                _context.Genres.Update(data);
                _context.SaveChanges();
                return await Task.FromResult(true);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }

        public async Task<bool> Delete(Guid id,Genres data, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _context.Genres.FindAsync(data.ID);
                obj.Deleted = true;
                obj.DeletedBy = data.DeletedBy;
                obj.DeletedTime = DateTime.UtcNow;
                _context.Genres.Update(obj);
                _context.SaveChanges();
                return await Task.FromResult(true);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }
    }
}
