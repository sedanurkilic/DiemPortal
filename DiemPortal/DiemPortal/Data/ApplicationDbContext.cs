using DiemPortal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DiemPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Request> Request { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Project> Project { get; set; }
    }
}