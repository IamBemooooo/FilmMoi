using AutoMapper;
using FilmMoi.Application.DataTransferObj.Actors;
using FilmMoi.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.ValueObj.Extentions.AutoMapper
{
    public class ActorsProfile : Profile
    {
        public ActorsProfile()
        {
            CreateMap<ActorDto,Actors>().ReverseMap();
        }
    }
}
