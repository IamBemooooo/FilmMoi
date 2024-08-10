using Client.ValueObj.Pagination;

namespace Client.Data.IServices.IReadOnlyService
{
    public interface IReadOnlyWPService<TDataDto, TDataVM>
    {
        public Task<PaginationResponse<TDataDto>> GetAll(TDataVM obj);

        public Task<TDataDto> GetById(Guid id);
    }
}
