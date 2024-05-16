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
    public class ActorsROWPRepository : IReadOnlyWPRepository<ActorDto, ActorWithPaginationRequest>
    {
        private readonly FilmMoiContext _context;
        public readonly IMapper _mapper;
        public ActorsROWPRepository(FilmMoiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<PaginationResponse<ActorDto>> GetAll(ActorWithPaginationRequest request, CancellationToken cancellationToken)
        {
            var queryable = from a in _context.Actors.AsNoTracking().Where(x => x.Deleted == false)
                            join b in _context.FilmActors.AsNoTracking() on a.ID equals b.ID_ACtor
                            where (!string.IsNullOrEmpty(request.Name) || request.ID != null) ?
                            b.ID_Film == request.ID || a.Name.Contains(request.Name!) : 1 == 1
                            select a;
                            

            var result = await queryable.PaginateAsync<Actors, ActorDto>(request, _mapper, cancellationToken);

            return new PaginationResponse<ActorDto>()
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
                HasNext = result.HasNext,
                Data = result.Data
            };

        }

        public async Task<ActorDto?> GetById(Guid id, CancellationToken cancellationToken)
        {
            Actors actors = await _context.Actors.FindAsync(id,cancellationToken);
            ActorDto actorDto = _mapper.Map<ActorDto>(actors);
            return actorDto;
        }
    }
}
