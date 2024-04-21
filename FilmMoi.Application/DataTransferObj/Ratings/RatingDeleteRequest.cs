using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.DataTransferObj.Ratings
{
    public class RatingDeleteRequest
    {
        public Guid ID_User { get; set; }

        public Guid ID_Film { get; set; }
    }
}
