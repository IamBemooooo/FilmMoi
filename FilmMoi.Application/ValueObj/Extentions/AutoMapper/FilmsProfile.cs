using AutoMapper;
using FilmMoi.Application.DataTransferObj.Films;
using FilmMoi.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.ValueObj.Extentions.AutoMapper
{
    public class FilmsProfile : Profile
    {
        public FilmsProfile()
        {
            CreateMap<FilmsCreateRequest, Films>();
            CreateMap<FilmsUpdateRequest, Films>();
            CreateMap<FilmsDeleteRequest, Films>();
            CreateMap<Films, FilmDto>();
            CreateMap<Films, Films>()
                .ForMember(x=>x.ID,o=>o.Ignore())
                .ForMember(x=>x.Status,o=>o.Ignore())
                .ForMember(x=>x.CreatedTime, o => o.Ignore())
                .ForMember(x=>x.AvgDuration, o => o.Ignore())
                .ForMember(x=>x.CreatedBy, o => o.Ignore());

        }
    }
}
