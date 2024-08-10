namespace Client.Data.IServices.IReadWriteService
{
    public interface IReadWriteRepository<TDataType>
    {
        public Task<bool> Create(TDataType data);
        public Task<bool> Update(Guid id, TDataType data);
        public Task<bool> Delete(Guid id, TDataType? data);
    }
}
