using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstProject.Models
{
    public partial class EmployeeSkill
    {
        public int EmployeeId { get; set; }
        public string SkillName { get; set; }
        public double? SkillLevel { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Skill SkillNameNavigation { get; set; }
    }
}
