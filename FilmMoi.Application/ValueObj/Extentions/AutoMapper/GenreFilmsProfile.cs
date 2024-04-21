using AutoMapper;
using FilmMoi.Application.DataTransferObj.GenreFilm;
using FilmMoi.Domain.Models.Entities;

namespace FilmMoi.Application.ValueObj.Extentions.AutoMapper
{
    public class GenreFilmsProfile : Profile
    {
        public GenreFilmsProfile()
        {
            CreateMap<GenreFilmCreateRequest,GenreFilms>();
            CreateMap<GenreFilmDeteleRequest, GenreFilms>();
        }
    }
}
