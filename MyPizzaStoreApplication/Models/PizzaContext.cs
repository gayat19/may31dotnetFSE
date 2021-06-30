using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPizzaStoreApplication.Models
{
    public class PizzaContext:DbContext
    {

        public PizzaContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().HasData(
                 new Pizza()
                 {
                     Id = 101,
                     Name = "Margherita",
                     IsVeg = true,
                     Crust = "Wheat Thin",
                     Price = 12,
                     Pic = "/images/Pic1.jpg"
                 },
            new Pizza()
            {
                Id = 102,
                Name = "Mexican Green Wave",
                IsVeg = true,
                Crust = "Cheezee",
                Price = 24,
                Pic = "/images/Pic2.jpg"
            });
        }
    }
}
