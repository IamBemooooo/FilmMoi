using FilmMoi.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Domain.Models.Entities
{
    public class Actors : EntityBase
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime Dob { get; set; }
        public string Nationality { get; set; }

        public virtual ICollection<FilmActors> filmActors { get; set; }
    }
}
