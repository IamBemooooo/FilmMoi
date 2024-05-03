using AutoMapper;
using FilmMoi.Application.DataTransferObj.WatchedFilms;
using FilmMoi.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.ValueObj.Extentions.AutoMapper
{
    public class WatchedFilmsProfile : Profile
    {
        public WatchedFilmsProfile()
        {
            CreateMap<WatchedFilmDto,WatchedFilms>().ReverseMap();
            CreateMap<WatchedFilmCreateRequest,WatchedFilms>();
            CreateMap<WatchedFilmDeleteRequest, WatchedFilms>();
        }
    }
}
