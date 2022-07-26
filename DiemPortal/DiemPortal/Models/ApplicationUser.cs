using Microsoft.AspNetCore.Identity;

namespace DiemPortal.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
    }
}
