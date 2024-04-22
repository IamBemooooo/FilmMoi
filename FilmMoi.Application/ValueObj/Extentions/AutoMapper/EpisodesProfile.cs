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
            CreateMap<EpisodesDto, Episodes>();
            CreateMap<Episodes, EpisodesDto>();
            CreateMap<EpisodesCreateRequest, Episodes>();
            CreateMap<EpisodesUpdateRequest, Episodes>();
            CreateMap<Episodes, Episodes>().ForMember(x=>x.CreatedTime,o=>o.Ignore()).ForMember(x=>x.ID,o=>o.Ignore()).ForMember(x=>x.ID_Film,o=>o.Ignore());

        }
    }
}
