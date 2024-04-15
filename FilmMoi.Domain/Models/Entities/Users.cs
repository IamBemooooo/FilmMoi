using Microsoft.AspNetCore.Identity;

namespace FilmMoi.Domain.Models.Entities
{
    public class Users : IdentityUser<Guid>
    {
        public Guid RoleId { get; set; }
        public virtual Roles Roles { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<WatchedFilms> WatchedFilms { get; set; }
        public virtual ICollection<Ratings> Ratings { get; set; }
    
    }
}
