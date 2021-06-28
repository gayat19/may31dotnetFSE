using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UnderstandingService.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Product name cannot be empty")]
        public string Name { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return Id + " " + Name + " " + Price;
        }
    }
}
