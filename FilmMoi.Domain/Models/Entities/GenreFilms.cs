﻿using FilmMoi.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Domain.Models.Entities
{
    public class GenreFilms : ICreatedBase, IModifiedBase
    {
        public Guid ID { get; set; }

        public Guid ID_Film { get; set; }
        public virtual Films Film { get; set; }

        public Guid ID_Genre { get; set; }
        public virtual Genres Genre { get; set; }
        public DateTimeOffset CreatedTime { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTimeOffset ModifiedTime { get; set; }

        public Guid? ModifiedBy { get; set; }
    }
}
