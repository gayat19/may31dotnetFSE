using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnderstandingDataTransferInMVCProject.Models
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
                new Department { Id=101,Name="Admin"}
                );
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id=1,Name="ABC",Age=24,Department_Id=101}
                );
        }
    }
}
