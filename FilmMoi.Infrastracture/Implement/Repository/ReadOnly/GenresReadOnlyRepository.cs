using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilmMoi.Application.DataTransferObj.Genres;
using FilmMoi.Application.Interface.ReadOnly;
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
    public class GenresReadOnlyRepository : IGenresReadOnlyRepository
    {
        private readonly FlimMoiContext _context;
        public readonly IMapper _mapper;

        public GenresReadOnlyRepository(FlimMoiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ICollection<GenreDto>> GetAllAsync(string name, CancellationToken cancellationToken)
        {
            ICollection<GenreDto> genres = null;
            if (string.IsNullOrEmpty(name))
            {
                genres = await _context.Genres.Where(x => x.Deleted == false)
                    .AsNoTracking().ProjectTo<GenreDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);
            }
            else
            {
                var filteredGenres = await _context.Genres
                    .AsNoTracking()
                    .Where(x => x.GenreName.ToLower().Contains(name.ToLower()) && x.Deleted == false)
                    .ToListAsync(cancellationToken);

                genres = _mapper.Map<ICollection<GenreDto>>(filteredGenres);
            }

            return genres;
        }

        public async Task<GenreDto> GetByIdAsync(string? id, CancellationToken cancellationToken)
        {
            Genres getGenre = await _context.Genres.FindAsync(Guid.Parse(id), cancellationToken);
            GenreDto genreDto = _mapper.Map<GenreDto>(getGenre);
            return genreDto;
        }
    }
}
