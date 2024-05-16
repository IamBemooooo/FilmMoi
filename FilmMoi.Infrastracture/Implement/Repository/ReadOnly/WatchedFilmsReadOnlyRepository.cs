using AutoMapper;
using Azure.Core;
using FilmMoi.Application.DataTransferObj.Comments;
using FilmMoi.Application.DataTransferObj.WatchedFilms;
using FilmMoi.Application.Interface.ReadOnly;
using FilmMoi.Application.ValueObj.Extentions.AutoMapper;
using FilmMoi.Application.ValueObj.Pagination;
using FilmMoi.Domain.Models;
using FilmMoi.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Infrastracture.Implement.Repository.ReadOnly
{
    public class WatchedFilmsReadOnlyRepository : IReadOnlyNPRepository<WatchedFilmDto>
    {
        private readonly FilmMoiContext _context;
        public readonly IMapper _mapper;
        public WatchedFilmsReadOnlyRepository(FilmMoiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ICollection<WatchedFilmDto>> GetAllAsync(string name, Guid id, CancellationToken cancellationToken)
        {
            var queryable = await (from a in _context.WatchedFilms.AsNoTracking()
                                   join b in _context.Films.AsNoTracking()
                                   on a.ID_Film equals b.ID where (id != null) ? (a.ID_User == id) : 1 == 1
                                   select new WatchedFilmDto
                                   {
                                       ID = a.ID,
                                       Name = b.Name,
                                       ID_Films = b.ID,
                                       CurrentPosition = a.CurrentPosition
                                   }).ToListAsync();
            return queryable;
        }

        public Task<WatchedFilmDto> GetByIdAsync(string? id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
