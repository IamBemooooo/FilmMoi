using Microsoft.AspNetCore.Identity;

namespace FilmMoi.Domain.Models.Entities
{
    public class Roles : IdentityRole<Guid>
    {
       public virtual ICollection<Users>? Users { get; set; }
    }
}
