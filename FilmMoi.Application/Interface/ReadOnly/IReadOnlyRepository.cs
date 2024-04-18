﻿using FilmMoi.Application.ValueObj.Pagination;

namespace FilmMoi.Application.Interface.ReadOnly
{
    public interface IReadOnlyRepository<TDataDto, TDataVM>
    {
        public Task<PaginationResponse<TDataDto>> GetAll(TDataVM obj, CancellationToken cancellationToken);

        public Task<TDataDto> GetById(Guid id, CancellationToken cancellationToken);
    }
}
