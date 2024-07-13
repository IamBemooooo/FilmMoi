namespace Client.Data.IServices.IReadOnlyService
{
    public interface IReadOnlyNPService<TDataDto>
    {
        public Task<ICollection<TDataDto>> GetAllAsync(string name, Guid id);
        public Task<TDataDto> GetByIdAsync(string? id);
    }
}
