namespace FilmMoi.Application.Interface.ReadWrite
{
    public interface IReadWriteRepository<TDataType>
    {
        public Task<bool> Create(TDataType data, CancellationToken cancellationToken);
        public Task<bool> Update(Guid id,TDataType data, CancellationToken cancellationToken);
        public Task<bool> Delete(Guid id, CancellationToken cancellationToken);
    }
}
