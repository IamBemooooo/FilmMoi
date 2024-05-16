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
    public class EpisodesReadWriteRepository : IReadWriteRepository<Episodes>
    {
        private readonly FilmMoiContext _db;
        private readonly IMapper _map;
        public EpisodesReadWriteRepository(IMapper map)
        {
            _db = new FilmMoiContext();
            _map = map;
        }
        public async Task<bool> Create(Episodes data, CancellationToken cancellationToken)
        {
            try
            {
                data.CreatedTime = DateTimeOffset.UtcNow;
                await _db.Episodes.AddAsync(data);
                await _db.SaveChangesAsync();
                await UpdateAvgDurationWithFilms(data.ID_Film, cancellationToken);
                return true;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Delete(Guid id, Episodes? data, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await GetById(id, cancellationToken);
                var getId = obj.ID_Film;
                _db.Episodes.Remove(obj);
                await _db.SaveChangesAsync();
                await UpdateAvgDurationWithFilms(getId, cancellationToken);

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Update(Guid id, Episodes data, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await GetById(id, cancellationToken);
                data.ModifiedTime = DateTimeOffset.UtcNow;
                _map.Map(data, obj);
                _db.Episodes.Update(obj);
                await _db.SaveChangesAsync();
                await UpdateAvgDurationWithFilms(obj.ID_Film, cancellationToken);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public async Task<Episodes?> GetById(Guid id, CancellationToken cancellationToken)
        {
            var obj = await _db.Episodes.FirstOrDefaultAsync(x => x.ID == id);
            return obj;
        }
        public async Task<Films?> UpdateAvgDurationWithFilms(Guid id, CancellationToken cancellationToken)
        {
            var episodesObj = await _db.Episodes.AsNoTracking().Where(x=>x.ID_Film == id).ToListAsync(); //4
            var count = episodesObj.Count();
            TimeSpan time = new TimeSpan();
            foreach (var item in episodesObj)
            {
                time = time.Add(item.Duration);
            }
            var avg = time / count;
            var obj = await _db.Films.FirstOrDefaultAsync(x => x.ID == id && !x.Deleted);
            obj.AvgDuration = avg;
            _db.Films.Update(obj);
            await _db.SaveChangesAsync();
            return obj;
        }
    }
}
