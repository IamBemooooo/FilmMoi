using AutoMapper;
using FilmMoi.Application.DataTransferObj.FilmActors;
using FilmMoi.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.ValueObj.Extentions.AutoMapper
{
    public class FilmActorsProfile : Profile
    {
        public FilmActorsProfile()
        {
            CreateMap<FilmActorCreateRequest, FilmActors>();
            CreateMap<FilmActorDeleteRequest, FilmActors>();
        }
    }
}
