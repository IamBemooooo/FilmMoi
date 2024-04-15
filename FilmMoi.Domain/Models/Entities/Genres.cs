using FilmMoi.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Domain.Models.Entities
{
    public class Genres : EntityBase
    {
        public Guid ID { get; set; }
        public string GenreName { get; set; }

        public virtual ICollection<GenreFilms> GenreFilms { get; set; }
    }
}
