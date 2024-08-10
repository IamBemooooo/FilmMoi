using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DataTransferObj.Ratings
{
    public class RatingCreateRequest
    {
        public int Rating { get; set; }
        public Guid ID_User { get; set; }

        public Guid ID_Film { get; set; }
    }
}
