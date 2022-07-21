using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DiemPortal.Models
{
    public class UserDetails:IdentityUser
    {
        [Display(Name="İsim")]
        public string Name { get; set; }
    }
}
