using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilmMoi.Application.DataTransferObj.Genres;
using FilmMoi.Application.Interface.ReadOnly;
using FilmMoi.Domain.Models;
using FilmMoi.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilmMoi.Infrastracture.Implement.Repository.ReadOnly
{
    public class GenresReadOnlyRepository : IReadOnlyNPRepository<GenreDto>
    {
        private readonly FilmMoiContext _context;
        public readonly IMapper _mapper;

        public GenresReadOnlyRepository(FilmMoiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ICollection<GenreDto>> GetAllAsync(string name, Guid id, CancellationToken cancellationToken)
        {
            ICollection<GenreDto> genres = null;
            if(id != null)
            {
                genres = await (from a in _context.Genres.AsNoTracking() join
                         b in _context.GenreFilms.AsNoTracking()
                         on a.ID equals b.ID_Genre 
                         where b.ID_Film == id 
                         select a).ProjectTo<GenreDto>(_mapper.ConfigurationProvider)
                         .ToListAsync(cancellationToken);

            } 
            else if (string.IsNullOrEmpty(name))
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
