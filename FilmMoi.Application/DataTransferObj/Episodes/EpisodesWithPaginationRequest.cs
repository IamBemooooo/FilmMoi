using FilmMoi.Application.ValueObj.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.DataTransferObj.Episodes
{
    public class EpisodesWithPaginationRequest : PaginationRequest
    {
        public Guid? Id { get; set; }
    }
}
