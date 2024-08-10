using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DataTransferObj.Episodes
{
    public class EpisodesDto
    {
        public string EpisodesName { get; set; }
        public string Film_Path { get; set; }
        public TimeSpan Duration { get; set; }
        public Guid ID_Film { get; set; }
        public string FilmName { get; set; }
        public string Image { get; set; }
    }
}
