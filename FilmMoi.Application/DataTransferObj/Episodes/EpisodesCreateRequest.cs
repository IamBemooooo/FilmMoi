using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.DataTransferObj.Episodes
{
    public class EpisodesCreateRequest
    {
        public string Name { get; set; }
        public string Film_Path { get; set; }
        public TimeSpan Duration { get; set; }
        public Guid ID_Film { get; set; }
    }
}
