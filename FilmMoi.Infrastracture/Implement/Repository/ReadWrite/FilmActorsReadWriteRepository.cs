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
    public class FilmActorsReadWriteRepository : IReadWriteRepository<FilmActors>
    {
        private FilmMoiContext _context;
        public IMapper _mapper;
        public FilmActorsReadWriteRepository(FilmMoiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Create(FilmActors data, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _context.FilmActors.FirstOrDefaultAsync(x => x.ID_ACtor == data.ID_ACtor && x.ID_Film == data.ID_Film);
                if (obj == null)
                {
                    data.CreatedTime = DateTime.UtcNow;
                    _context.FilmActors.Add(data);
                    _context.SaveChanges();
                    return await Task.FromResult(true);
                }
                return await Task.FromResult(false);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }

        public async Task<bool> Delete(Guid id, FilmActors? data, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _context.FilmActors.FirstOrDefaultAsync(x => x.ID_ACtor == data.ID_ACtor && x.ID_Film == data.ID_Film);
                _context.FilmActors.Remove(obj);
                await _context.SaveChangesAsync();
                return await Task.FromResult(true);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }

        public Task<bool> Update(Guid id, FilmActors data, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
