using AutoMapper;
using Azure.Core;
using FilmMoi.Application.DataTransferObj.Actors;
using FilmMoi.Application.DataTransferObj.Comments;
using FilmMoi.Application.Interface.ReadOnly;
using FilmMoi.Application.ValueObj.Extentions;
using FilmMoi.Application.ValueObj.Pagination;
using FilmMoi.Domain.Models;
using FilmMoi.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Infrastracture.Implement.Repository.ReadOnly
{
    public class CommentROWPRepository : IReadOnlyWPRepository<CommentDto, CommentWithPaginationRequest>
    {
        private readonly FlimMoiContext _context;
        public readonly IMapper _mapper;
        public CommentROWPRepository(FlimMoiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<CommentDto>> GetAll(CommentWithPaginationRequest request, CancellationToken cancellationToken)
        {
            var queryable = _context.Comments.AsNoTracking().Where(x => x.ID_Film == request.ID);
            var users = _context.Users.AsNoTracking();
            var result = await queryable.PaginateAsync<Comments, CommentDto>(request,_mapper,cancellationToken);
            result.Data = (from a in result.Data join 
                          b in users on a.ID_User equals b.Id
                          select new CommentDto 
                          {
                              ID = a.ID,
                              Comment_text = a.Comment_text,
                              ID_User = a.ID_User,
                              UserName = b.UserName,
                          }).ToList();
            return new PaginationResponse<CommentDto>()
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
                HasNext = result.HasNext,
                Data = result.Data
            };
        }

        public async Task<CommentDto?> GetById(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
