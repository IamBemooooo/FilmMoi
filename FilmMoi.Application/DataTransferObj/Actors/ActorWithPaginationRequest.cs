using FilmMoi.Application.ValueObj.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.DataTransferObj.Actors
{
    public class ActorWithPaginationRequest : PaginationRequest
    {
        public string? Name { get; set; }
    }
}
