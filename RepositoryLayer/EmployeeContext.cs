using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options): base(options) { }
        public DbSet<Employee> EmployeeAjaxRef { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Name).IsRequired().HasMaxLength(150);
                entity.Property(e => e.State).IsRequired().HasMaxLength(150);
                entity.Property(e => e.city).IsRequired().HasMaxLength(150);
                
            });
        }
    }
}
