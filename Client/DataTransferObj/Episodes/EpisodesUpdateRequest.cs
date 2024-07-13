using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DataTransferObj.Episodes
{
    public class EpisodesUpdateRequest
    {
        public string Name { get; set; }
        public string Film_Path { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
