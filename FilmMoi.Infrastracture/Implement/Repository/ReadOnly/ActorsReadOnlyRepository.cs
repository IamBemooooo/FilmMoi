using AutoMapper;
using Azure.Core;
using FilmMoi.Application.DataTransferObj.Actors;
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
    public class ActorsReadOnlyRepository : IActorsReadOnlyrepository
    {
        private readonly FlimMoiContext _context;
        public readonly IMapper _mapper;
        public ActorsReadOnlyRepository(FlimMoiContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;   
        }
        public async Task<PaginationResponse<ActorDto>> GetActorWithPaginationRequest(ActorWithPaginationRequest request, CancellationToken cancellationToken)
        {
            var queryable = _context.Actors.AsNoTracking().Where(x => x.Deleted == false);

            // check if search field is null
            if (!string.IsNullOrWhiteSpace(request.Name))
            {
                queryable = queryable.Where(c => c.Name.Contains(request.Name!));
            }

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
