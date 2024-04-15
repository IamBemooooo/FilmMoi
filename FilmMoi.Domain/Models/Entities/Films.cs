using FilmMoi.Domain.Models.Base;
using FilmMoi.Domain.Models.Entities;
using FilmMoi.Domain.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Models.Models.Entities
{
    public class Films : EntityBase
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public TimeSpan Duration { get; set; }
        public string Description { get; set; }
        public FilmStatus Status { get; set; }
        public DateTime Year { get; set; }
        public string Director { get; set; }

        public virtual ICollection<FilmActors> filmActors { get; set; }
        public virtual ICollection<GenreFilms> GenreFilms { get; set; }
        public virtual ICollection<Episodes> Episodes { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<WatchedFilms> WatchedFilms { get; set; }
    }
}
