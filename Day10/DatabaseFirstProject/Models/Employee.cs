using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstProject.Models
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeSkills = new HashSet<EmployeeSkill>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Area { get; set; }
        public string Phone { get; set; }

        public virtual Area AreaNavigation { get; set; }
        public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
