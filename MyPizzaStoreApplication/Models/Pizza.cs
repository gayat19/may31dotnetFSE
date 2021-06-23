using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPizzaStoreApplication.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsVeg { get; set; }
        public float Price { get; set; }
        public string Crust { get; set; }
        public string Pic { get; set; }
    }
}
