using FilmMoi.Application.DataTransferObj.Films;
using FilmMoi.Application.Interface;
using FilmMoi.Application.ValueObj.Pagination;

namespace FilmMoi.Infrastructure.Implement.Repository.ReadOnly
{
    public class FilmsReadOnlyRepository : IReadOnlyRepository<FilmDto, FilmsWithPaginationRequest>
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
