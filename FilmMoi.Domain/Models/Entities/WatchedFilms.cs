using FilmMoi.Domain.Models.Base;
using FilmMoi.Models.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Domain.Models.Entities
{
    public class WatchedFilms : EntityBase
    {
        public Guid ID { get; set; }
        public TimeSpan CurrentPosition { get; set; }

        public Guid ID_User { get; set; }
        public virtual Users User { get; set; }

        public Guid ID_Film { get; set; }
        public virtual Films Film { get; set; }
    }
}
