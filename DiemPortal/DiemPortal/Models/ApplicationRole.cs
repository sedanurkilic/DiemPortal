using Microsoft.AspNetCore.Identity;

namespace DiemPortal.Models
{
    public class ApplicationRole: IdentityRole
    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string roleName) : base(roleName) { }
    }
}
