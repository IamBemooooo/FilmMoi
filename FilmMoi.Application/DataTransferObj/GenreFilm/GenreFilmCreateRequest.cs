using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.DataTransferObj.GenreFilm
{
    public class GenreFilmCreateRequest
    {
        public Guid ID_Film { get; set; }
        public Guid ID_Genre { get; set; }
    }
}
