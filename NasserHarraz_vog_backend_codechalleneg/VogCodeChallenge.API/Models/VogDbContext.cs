using System;
using Microsoft.EntityFrameworkCore;

namespace VogCodeChallenge.API.Models
{
    public class VogDbContext : DbContext
    {
        public VogDbContext(DbContextOptions<VogDbContext> options) : base(options)
        {
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Department>()
                .HasIndex(u => u.Address)
                .IsUnique();
        }
    }
}
