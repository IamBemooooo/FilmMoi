using FilmMoi.Domain.Models.Base;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace FilmMoi.Domain.Models.Entities
{
    public class Users : IdentityUser<Guid>, ICreatedBase, IModifiedBase
    {
        public Guid RoleId { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTimeOffset ModifiedTime { get; set; }
        public Guid? ModifiedBy { get; set; }
        public virtual Roles Roles { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<WatchedFilms> WatchedFilms { get; set; }
        public virtual ICollection<Ratings> Ratings { get; set; }

    }
}
