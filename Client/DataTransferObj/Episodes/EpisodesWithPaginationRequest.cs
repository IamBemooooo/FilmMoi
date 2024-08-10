using Client.ValueObj.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DataTransferObj.Episodes
{
    public class EpisodesWithPaginationRequest : PaginationRequest
    {
        public Guid? Id { get; set; }
    }
}
