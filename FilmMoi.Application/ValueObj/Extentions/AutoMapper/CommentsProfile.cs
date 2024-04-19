using AutoMapper;
using FilmMoi.Application.DataTransferObj.Comments;
using FilmMoi.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.ValueObj.Extentions.AutoMapper
{
    public class CommentsProfile : Profile
    {
        public CommentsProfile()
        {
            CreateMap<CommentDto,Comments>().ReverseMap();
        }
    }
}
