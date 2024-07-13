using Client.ValueObj.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DataTransferObj.Users
{
    public class UsersWithPaginationRequest : PaginationRequest
    {
        public string? UserName { get; set; }
    }
}
