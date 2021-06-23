using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnderstandingDBConProject.Models
{
    public class CompanyContext :DbContext
    {
        public CompanyContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
               new Department() { Id = 1, Name = "Accounts" },
                 new Department() { Id = 2, Name = "Operations" }
               );
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { 
                    Id=101,
                    Name="ABC",
                    Age=21,
                    Department_Id=1
                   }, new Employee()
                   {
                       Id = 102,
                       Name = "XYZ",
                       Age = 32,
                       Department_Id = 1
                   }
                );
           
        }
    }
}
