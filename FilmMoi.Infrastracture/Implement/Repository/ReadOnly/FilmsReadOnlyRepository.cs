using FilmMoi.Application.DataTransferObj.Films;
using FilmMoi.Application.Interface.ReadOnly;
using FilmMoi.Application.ValueObj.Pagination;

namespace FilmMoi.Infrastructure.Implement.Repository.ReadOnly
{
    public class FilmsReadOnlyRepository : IFilmsReadOnlyRepository<FilmDto, FilmsWithPaginationRequest>
    {
        public Task<PaginationResponse<FilmDto?>> GetAll(FilmsWithPaginationRequest? obj, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<FilmDto?> GetById(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
