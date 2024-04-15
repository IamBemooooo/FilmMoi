using Microsoft.AspNetCore.Identity;

namespace FilmMoi.Domain.Models.Entities
{
    public class Roles : IdentityUser<Guid>
    {
        ICollection<Users> Users { get; set; }
    }
}
