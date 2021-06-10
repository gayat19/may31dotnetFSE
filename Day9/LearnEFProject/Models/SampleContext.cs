using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEFProject.Models
{
    public class SampleContext : DbContext
    {
        readonly string connectionString = @"Data source=DESKTOP-1C1EU5R;Integrated security=true;Initial Catalog=dbJune10CodeFirst";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee()
                {
                    Id = 101,
                    Name = "ABC",
                    Date_Of_Birth = new DateTime(1990, 06, 12)
                }
                ); 
        }
    }
}
