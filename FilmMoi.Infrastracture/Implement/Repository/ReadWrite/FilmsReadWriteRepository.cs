using AutoMapper;
using Azure.Core;
using FilmMoi.Application.DataTransferObj.Films;
using FilmMoi.Application.Interface.ReadWrite;
using FilmMoi.Domain.Models;
using FilmMoi.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Infrastructure.Implement.Repository.ReadWrite
{
    public class FilmsReadWriteRepository : IReadWriteRepository<Films>
    {
        private readonly FlimMoiContext _db;
        private readonly IMapper _map;

        public FilmsReadWriteRepository(IMapper map)
        {
            _db = new FlimMoiContext();
            _map = map;

        }

        public async Task<bool> Create(Films data, CancellationToken cancellationToken)
        {
            try
            {
                data.CreatedTime = DateTimeOffset.UtcNow;
                data.AvgDuration = TimeSpan.Zero;
                data.TotalEpisode = 0;
                await _db.Films.AddAsync(data);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }     
        public async  Task<bool> Delete(Guid id, Films? data, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await GetById(id, cancellationToken);
                obj.Deleted = true;
                obj.DeletedBy = data.DeletedBy;
                _db.Films.Update(obj);
                await _db.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public async Task<bool> Update(Guid id,Films data,CancellationToken cancellationToken)
        {
            try
            {
                var obj = await GetById(id, cancellationToken);
                data.ModifiedTime = DateTimeOffset.UtcNow;
                _map.Map(data, obj);
                _db.Films.Update(obj);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public async Task<Films?> GetById(Guid id, CancellationToken cancellationToken)
        {
            var obj = await _db.Films.FirstOrDefaultAsync(x => x.ID == id && !x.Deleted);
            return obj;
        }

        public Task<bool> Delete(Guid id, Films? data, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
