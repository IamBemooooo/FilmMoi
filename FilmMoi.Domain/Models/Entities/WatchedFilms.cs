using FilmMoi.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Domain.Models.Entities
{
    public class WatchedFilms : ICreatedBase, IModifiedBase
    {
        public Guid ID { get; set; }
        public TimeSpan CurrentPosition { get; set; }

        public Guid ID_User { get; set; }
        public virtual Users User { get; set; }

        public Guid ID_Film { get; set; }
        public virtual Films Film { get; set; }
        public DateTimeOffset CreatedTime { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTimeOffset ModifiedTime { get; set; }

        public Guid? ModifiedBy { get; set; }
    }
}
