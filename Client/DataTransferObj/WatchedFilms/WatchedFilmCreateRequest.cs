using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DataTransferObj.WatchedFilms
{
    public class WatchedFilmCreateRequest
    {
        public Guid ID_User { get; set; }

        public Guid ID_Film { get; set; }

        public TimeSpan CurrentPosition { get; set; }
    }
}
