using Client.Enum;
using Client.ValueObj.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DataTransferObj.Films
{
    public class FilmsWithPaginationRequest : PaginationRequest
    {       
        public string? Name { get; set; }
        public decimal Rating { get; set; }
        public Guid? Genre { get; set; }
        public int? Year { get; set; }
        public FilmStatus? Status { get; set; }
                
    }
}
