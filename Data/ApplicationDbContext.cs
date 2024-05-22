using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Net.Models;

namespace Project.Net.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Project.Net.Models.Flight> Flight { get; set; } = default!;
        public DbSet<Project.Net.Models.Passenger> Passenger { get; set; } = default!;
        public DbSet<Project.Net.Models.Plane> Plane { get; set; } = default!;
    }
}
