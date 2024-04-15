using Microsoft.AspNetCore.Identity;

namespace FilmMoi.Domain.Models.Entities
{
    public class Users : IdentityUser<Guid>
    {
        public Guid ID_Role { get; set; }
        public Roles Role { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<WatchedFilms> WatchedFilms { get; set; }
        public virtual ICollection<Operations> Operations { get; set; }
    }
}
