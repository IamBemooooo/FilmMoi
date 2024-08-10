using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilmMoi.Application.DataTransferObj.Films;
using FilmMoi.Application.DataTransferObj.Ratings;
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
        private readonly FilmMoiContext _db;
        private readonly IMapper _map;
        private readonly IReadOnlyNPRepository<RatingDto> _rating;

        public FilmsReadOnlyRepository()
        {
            
        }
        public FilmsReadOnlyRepository(IMapper map, IReadOnlyNPRepository<RatingDto> rating)
        {
            _db = new FilmMoiContext();
            _map = map;
            _rating = rating;
        }

        public async Task<PaginationResponse<FilmDto>> GetAll(FilmsWithPaginationRequest obj, CancellationToken cancellationToken)
        {
            var query = _db.Films.Include(x => x.GenreFilms).Include(x=>x.Ratings).Include(x => x.GenreFilms).AsNoTracking();
            if (obj.Status != null)
            {
                query = query.Where(x => x.Status == obj.Status);
            }
            if (!string.IsNullOrWhiteSpace(obj.Name))
            {
               query = query.Where(x => x.Name.Contains(obj.Name));
            }
            if (obj.Rating != 0)
            {
                query = query.Where(x => x.Ratings.Count > 0);
                query = query.Where(x => Math.Floor((double)(x.Ratings.Sum(r => r.Rating) / x.Ratings.Count)) == (double)obj.Rating);
            }
            if (obj.Genre != null)
            {
                query = query.Where(x => x.GenreFilms.Any(x => x.ID_Genre == obj.Genre));
            }
            if (obj.Year != null)
            {
                query = query.Where(x => x.Year == obj.Year);
            }

            var result = await query.PaginateAsync<Films, FilmDto>(obj, _map, cancellationToken);

            return new PaginationResponse<FilmDto>()
            {
                PageSize = result.PageSize,
                HasNext = result.HasNext,
                PageNumber = result.PageNumber,
                Data = result.Data
            };
        }

        public async Task<FilmDto> GetById(Guid id, CancellationToken cancellationToken)
        {
           var obj = await _db.Films.AsNoTracking().Where(x=>x.ID == id && !x.Deleted).FirstOrDefaultAsync(cancellationToken);
           var result = _map.Map<FilmDto>(obj);
           return result;

        }
    }
}
