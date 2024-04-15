namespace FilmMoi.Application.Interface
{
    public interface IReadWriteRepository<TDataType>
    {
        public Task<bool> Create(TDataType data, CancellationToken cancellationToken);
        public Task<bool> Update(TDataType data, CancellationToken cancellationToken);
        public Task<bool> Delete(Guid id, CancellationToken cancellationToken);
    }
}
