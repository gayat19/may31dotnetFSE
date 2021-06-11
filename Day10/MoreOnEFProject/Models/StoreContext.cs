using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnEFProject.Models
{
    public class StoreContext: DbContext
    {
        readonly string connectionString = @"Data source=DESKTOP-1C1EU5R;Integrated security=true;Initial Catalog=dbStoreJune11";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<User> users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //only if u need to seed the data
            modelBuilder.Entity<User>().HasData(new User
            {
                Username = "ABC",
                Password = "123"
            });
            modelBuilder.Entity<BillDetail>().HasKey(k =>new {k.BillNumber,k.ItemId});
        }
    }
}
