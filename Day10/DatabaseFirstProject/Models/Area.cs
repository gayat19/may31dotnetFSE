using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstProject.Models
{
    public partial class Area
    {
        public Area()
        {
            Employees = new HashSet<Employee>();
        }

        public string AreaName { get; set; }
        public string ZipCode { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
