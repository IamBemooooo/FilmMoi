using FilmMoi.Application.ValueObj.Pagination;
using FilmMoi.Domain.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.DataTransferObj.Films
{
    public class FilmsWithPaginationRequest : PaginationRequest
    {       
        public string? Name { get; set; }

        public decimal Rating { get; set; }
        public FilmStatus? Status { get; set; }

                
    }
}
