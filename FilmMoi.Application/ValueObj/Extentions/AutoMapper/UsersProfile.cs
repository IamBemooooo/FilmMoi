using AutoMapper;
using FilmMoi.Application.DataTransferObj.Users;
using FilmMoi.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.ValueObj.Extentions.AutoMapper
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<UserDto,Users>().ReverseMap();
            CreateMap<UsersCreateRequest,Users>();
            CreateMap<UserDeleteRequest,Users>();
            CreateMap<UsersUpdateRequest,Users>();

        }
    }
}
