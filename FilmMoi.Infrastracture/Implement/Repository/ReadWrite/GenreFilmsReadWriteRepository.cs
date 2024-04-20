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
    public class GenreFilmsReadWriteRepository : IReadWriteRepository<GenreFilms>
    {
        private FlimMoiContext _context;
        public IMapper _mapper;
        public GenreFilmsReadWriteRepository(FlimMoiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> Create(GenreFilms data, CancellationToken cancellationToken)
        {
            try
            {
                data.CreatedTime = DateTime.UtcNow;
                _context.GenreFilms.Add(data);
                _context.SaveChanges();
                return await Task.FromResult(true);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }

        public async Task<bool> Delete(Guid id, GenreFilms? data, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _context.GenreFilms.FirstOrDefaultAsync(x => x.ID_Genre == data.ID_Genre && x.ID_Film == data.ID_Film);
                _context.GenreFilms.Remove(obj);
                await _context.SaveChangesAsync();
                return await Task.FromResult(true);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }

        public Task<bool> Update(Guid id, GenreFilms data, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
