using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingWithModelProject.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public override bool Equals(object obj)
        {
            return this.Id.Equals(((Item)obj).Id);
        }
    }
}
