using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DataTransferObj.Genres
{
    public class GenreCreateRequest
    {
        public string GenreName { get; set; }
        public Guid? CreatedBy { get; set; }
    }
}
