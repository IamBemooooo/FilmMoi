using FilmMoi.Application.DataTransferObj.Genres;
using FilmMoi.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.Interface.ReadOnly
{
    public interface IGenresReadOnlyRepository
    {
        public Task<ICollection<GenreDto>> GetAllAsync(string name, CancellationToken cancellationToken);
        public Task<GenreDto> GetByIdAsync(string? id,CancellationToken cancellationToken);
    }
}
