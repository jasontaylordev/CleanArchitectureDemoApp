using Microsoft.EntityFrameworkCore;
using Vertical.Domain.Entities;
using Vertical.Persistance.Extensions;

namespace Vertical.Persistance
{
    public class VerticalDbContext : DbContext
    {
        public VerticalDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyAllConfigurations();
        }
    }
}