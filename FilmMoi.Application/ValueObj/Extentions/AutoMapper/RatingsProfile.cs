using AutoMapper;
using FilmMoi.Application.DataTransferObj.Ratings;
using FilmMoi.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.ValueObj.Extentions.AutoMapper
{
    public class RatingsProfile : Profile
    {
        public RatingsProfile()
        {
            CreateMap<RatingDto,Ratings>().ReverseMap();
            CreateMap<RatingDeleteRequest, Ratings>();
            CreateMap<RatingCreateRequest, Ratings>();
            CreateMap<RatingUpdateRequest, Ratings>().ForMember(x => x.CreatedTime, o => o.Ignore())
                .ForMember(x => x.CreatedBy, o => o.Ignore());
        }
    }
}
