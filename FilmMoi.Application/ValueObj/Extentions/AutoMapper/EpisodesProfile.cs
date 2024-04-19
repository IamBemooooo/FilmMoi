using AutoMapper;
using FilmMoi.Application.DataTransferObj.Episodes;
using FilmMoi.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.ValueObj.Extentions.AutoMapper
{
    public class EpisodesProfile : Profile
    {
        public EpisodesProfile()
        {
            CreateMap<EpisodesDto, Episodes>().ReverseMap();
        }
    }
}
