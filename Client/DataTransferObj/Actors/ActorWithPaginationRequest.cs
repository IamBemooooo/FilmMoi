using Client.ValueObj.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DataTransferObj.Actors
{
    public class ActorWithPaginationRequest : PaginationRequest
    {
        public Guid? ID { get; set; }
        public string? Name { get; set; }
    }
}
