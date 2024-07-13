using Client.ValueObj.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DataTransferObj.Comments
{
    public class CommentWithPaginationRequest : PaginationRequest
    {
        public Guid ID { get; set; }
    }
}
