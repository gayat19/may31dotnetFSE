using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstProject.Models
{
    public partial class Skill
    {
        public Skill()
        {
            EmployeeSkills = new HashSet<EmployeeSkill>();
        }

        public string SkillName { get; set; }
        public string SkillDescription { get; set; }

        public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
