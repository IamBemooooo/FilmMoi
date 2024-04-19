using AutoMapper;
using FilmMoi.Application.DataTransferObj.Episodes;
using FilmMoi.Application.Interface.ReadOnly;
using FilmMoi.Application.ValueObj.Extentions;
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
    public class EpisodesReadOnlyRepository : IReadOnlyWPRepository<EpisodesDto, EpisodesWithPaginationRequest>
    {
        private readonly FlimMoiContext _context;
        private readonly IMapper _map;

        public EpisodesReadOnlyRepository(IMapper map)
        {
            _context = new FlimMoiContext();
            _map = map;
        }

        public async Task<PaginationResponse<EpisodesDto>> GetAll(EpisodesWithPaginationRequest request, CancellationToken cancellationToken)
        {
            var query = _context.Episodes.AsNoTracking().Where(x=>x.ID == request.Id).Include(x=>x.Film);
            var result = await query.PaginateAsync<Episodes, EpisodesDto>(request, _map, cancellationToken);
            result.Data = (from a in query
                           select new EpisodesDto
                           {
                               Duration = a.Duration,
                               Film_Path = a.Film_Path,
                               ID_Film = a.ID_Film,
                               EpisodesName = a.Name,
                               FilmName = a.Film.Name,
                               Image = a.Film.Image
                           }).ToList();
            return new PaginationResponse<EpisodesDto>()
            {
                Data = result.Data,
                HasNext = result.HasNext,
                PageSize = result.PageSize,
                PageNumber = result.PageNumber,
            };
        }

        public Task<EpisodesDto> GetById(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
