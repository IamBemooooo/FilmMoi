using AutoMapper;
using FilmMoi.Application.DataTransferObj.Films;
using FilmMoi.Application.Interface.ReadOnly;
using FilmMoi.Application.ValueObj.Extentions;
using FilmMoi.Application.ValueObj.Pagination;
using FilmMoi.Domain.Models;
using FilmMoi.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilmMoi.Infrastructure.Implement.Repository.ReadOnly
{
    public class FilmsReadOnlyRepository : IReadOnlyWPRepository<FilmDto, FilmsWithPaginationRequest>
    {
        private readonly FlimMoiContext _db;
        private readonly IMapper _map;

        public FilmsReadOnlyRepository(IMapper map)
        {
            _db = new FlimMoiContext();
            _map = map;
        }

        public async Task<PaginationResponse<FilmDto>> GetAll(FilmsWithPaginationRequest obj, CancellationToken cancellationToken)
        {
            var query = _db.Films.AsNoTracking();
            if (!string.IsNullOrWhiteSpace(obj.Name))
            {
                query.Where(x => x.Name.Contains(obj.Name));
            }
            query.OrderBy(x => x.Status);
            var result = await query.PaginateAsync<Films, FilmDto>(obj, _map, cancellationToken);

            return new PaginationResponse<FilmDto>()
            {
                PageSize = result.PageSize,
                HasNext = result.HasNext,
                PageNumber = result.PageNumber,
                Data = result.Data
            };
                
            


        }

        public Task<FilmDto?> GetById(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
