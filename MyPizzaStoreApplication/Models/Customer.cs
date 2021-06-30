using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPizzaStoreApplication.Models
{
    public class Customer
    {
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address  { get; set; }
        public int  Age { get; set; }
        public string Phone { get; set; }

    }
}
