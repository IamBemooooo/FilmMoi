using FilmMoi.Application.Interface;
using FilmMoi.Domain.Models;
using FilmMoi.Models.Models;
using FilmMoi.Models.Models.Entities;
using System;
using System.Collections.Generic;
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

        public Task<bool> Create(Films data, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Films data, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
