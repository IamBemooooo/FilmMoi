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

        public FilmsReadWriteRepository()
        {
            _db = new FlimMoiContext();
        }

        public async Task<bool> Create(Films data, CancellationToken cancellationToken)
        {
            try
            {
                await _db.Films.AddAsync(data);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Delete(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await GetById(id,cancellationToken);
                _db.Films.Remove(obj);
                await _db.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Update(Guid id,Films data, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await GetById(id, cancellationToken);
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
    }
}
