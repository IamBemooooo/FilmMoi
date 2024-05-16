using AutoMapper;
using FilmMoi.Application.Interface.ReadWrite;
using FilmMoi.Application.ValueObj.Extentions.AutoMapper;
using FilmMoi.Domain.Models.Entities;
using FilmMoi.Domain.Models;

namespace FilmMoi.Infrastracture.Implement.Repository.ReadWrite
{
    public class WatchedFilmsReadWriteRepository : IReadWriteRepository<WatchedFilms>
    {
        private FilmMoiContext _context;
        public IMapper _mapper;
        public WatchedFilmsReadWriteRepository(FilmMoiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Create(WatchedFilms data, CancellationToken cancellationToken)
        {
            try
            {
                data.CreatedTime = DateTime.UtcNow;
                _context.WatchedFilms.Add(data);
                _context.SaveChanges();
                return await Task.FromResult(true);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }

        public async Task<bool> Delete(Guid id, WatchedFilms? data, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await GetById(id);

                _context.WatchedFilms.Remove(obj);
                await _context.SaveChangesAsync();
                return await Task.FromResult(true);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }

        private async Task<WatchedFilms> GetById(Guid id)
        {
            var obj = await _context.WatchedFilms.FindAsync(id);
            return obj;
        }

        public Task<bool> Update(Guid id, WatchedFilms data, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
