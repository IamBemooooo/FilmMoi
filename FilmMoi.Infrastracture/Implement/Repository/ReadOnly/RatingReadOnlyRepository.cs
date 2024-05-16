using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilmMoi.Application.DataTransferObj.Ratings;
using FilmMoi.Application.Interface.ReadOnly;
using FilmMoi.Application.ValueObj.Pagination;
using FilmMoi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Infrastracture.Implement.Repository.ReadOnly
{
    public class RatingReadOnlyRepository : IReadOnlyNPRepository<RatingDto>
    {
        private readonly FilmMoiContext _context;
        public readonly IMapper _mapper;
        public RatingReadOnlyRepository(FilmMoiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ICollection<RatingDto>> GetAllAsync(string name, Guid id, CancellationToken cancellationToken)
        {
            if (id != null)
            {
                var queryable = _context.Ratings.AsNoTracking().Where(x => x.ID_Film == id)
                    .ProjectTo<RatingDto>(_mapper.ConfigurationProvider);

                var ratings = await queryable.ToListAsync(cancellationToken);
                return ratings;
            }

            // Handle the case when id is null
            throw new ArgumentNullException(nameof(id), "The id parameter cannot be null.");
        }

        public Task<RatingDto> GetByIdAsync(string? id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
