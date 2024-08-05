using Microsoft.AspNetCore.Identity;

namespace AuthAPI_902.Models
{
    public class AppUser : IdentityUser
    {
        public string? FullName { get; set; }

    }
}
