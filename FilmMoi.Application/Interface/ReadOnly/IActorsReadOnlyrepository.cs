using FilmMoi.Application.DataTransferObj.Actors;
using FilmMoi.Application.ValueObj.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.Interface.ReadOnly
{
    public interface IActorsReadOnlyrepository
    {
        public Task<ActorDto?> GetById(Guid id, CancellationToken cancellationToken);

        public Task<PaginationResponse<ActorDto>> GetActorWithPaginationRequest(ActorWithPaginationRequest obj, CancellationToken cancellationToken);
    }
}
