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
            CreateMap<CommentCreateRequest, Comments>();
            CreateMap<CommentUpdateRequest, Comments>();
            CreateMap<CommentDeleteRequest, Comments>();
            CreateMap<Comments, Comments>().ForMember(x => x.CreatedTime, o => o.Ignore())
                .ForMember(x => x.ModifiedTime, o => o.Ignore())
                .ForMember(x => x.ID_Film, o => o.Ignore())
                .ForMember(x => x.ID_User, o => o.Ignore());
        }
    }
}
