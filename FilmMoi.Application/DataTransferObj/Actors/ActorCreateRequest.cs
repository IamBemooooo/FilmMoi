using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.DataTransferObj.Actors
{
    public class ActorCreateRequest
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime Dob { get; set; }
        public string Nationality { get; set; }
    }
}
