﻿using FilmMoi.Domain.Models.Base;
using FilmMoi.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Domain.Models.Entities
{
    public class Episodes : ICreatedBase, IModifiedBase
    {
        public Guid ID { get; set; }

        public string Name { get; set; }
        public string Film_Path { get; set; }
        public TimeSpan Duration { get; set; }
        public Guid ID_Film { get; set; }
        public virtual Films Film { get; set; }
        public DateTimeOffset CreatedTime { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTimeOffset ModifiedTime { get; set; }

        public Guid? ModifiedBy { get; set; }
    }
}
