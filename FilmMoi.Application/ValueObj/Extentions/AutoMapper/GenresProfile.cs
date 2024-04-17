using AutoMapper;
using FilmMoi.Application.DataTransferObj.Genres;
using FilmMoi.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.ValueObj.Extentions.AutoMapper
{
    public class GenresProfile : Profile
    {
        public GenresProfile()
        {
            CreateMap<Genres,GenreDto>().ReverseMap();
            CreateMap<GenreCreateRequest, Genres>();
            CreateMap<GenreDeleteRequest, Genres>();
            CreateMap<GenreUpdateRequest, Genres>();
            CreateMap<Genres, Genres>().ForAllMembers(opts => opts.Condition((src, dest, srcMember, destMember) =>
            srcMember != null && !srcMember.Equals(destMember)));
        }
    }
}
