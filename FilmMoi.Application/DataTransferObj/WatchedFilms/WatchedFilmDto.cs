using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.DataTransferObj.WatchedFilms
{
    public class WatchedFilmDto
    {
        public Guid ID { get; set; }
        public Guid ID_Films { get; set; }
        public string Name { get; set; }
        public TimeSpan CurrentPosition { get; set; }   
    }
}
