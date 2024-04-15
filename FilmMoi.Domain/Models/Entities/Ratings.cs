using FilmMoi.Domain.Models.Base;

namespace FilmMoi.Domain.Models.Entities
{
    public class Ratings : ICreatedBase, IModifiedBase
    {
        public Guid ID_User { get; set; }
        public Guid ID_Film { get; set; }
        public int Rating { get; set; }
        public virtual Films Film { get; set; }

        public virtual Users User { get; set; }
        public DateTimeOffset CreatedTime { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTimeOffset ModifiedTime { get; set; }

        public Guid? ModifiedBy { get; set; }
    }
}
