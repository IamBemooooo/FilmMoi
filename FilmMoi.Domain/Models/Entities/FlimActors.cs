﻿using FilmMoi.Domain.Models.Base;
using FilmMoi.Models.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Domain.Models.Entities
{
    public class FilmActors : ICreatedBase, IModifiedBase
    {
        public Guid ID { get; set; }

        public Guid ID_Film { get; set; }
        public virtual Films Film { get; set; }

        public Guid ID_ACtor { get; set; }
        public virtual Actors Actor { get; set; }
        public DateTimeOffset CreatedTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid? CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTimeOffset ModifiedTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid? ModifiedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
