using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using ProjectOne.Models;

namespace ProjectOne.Data
{
    public class ProjectOneContext : DbContext
    {
        public ProjectOneContext(DbContextOptions<ProjectOneContext> options)
           : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}
