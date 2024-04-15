﻿using FilmMoi.Domain.Models.Base;
using FilmMoi.Models.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Domain.Models.Entities
{
    public class Episodes : EntityBase
    {
        public Guid ID { get; set; }
        public string Film_Path { get; set; }

        public Guid ID_Film { get; set; }
        public virtual Films Film { get; set; }
    }
}
