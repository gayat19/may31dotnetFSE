using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExampleProject
{
    public class Skill
    {
        public string Skill_name { get; set; }
        public string Skill_Description { get; set; }
        public override string ToString()
        {
            return "Skill name : " + Skill_name +
                "\nSkill Description : " + Skill_Description;
        }
    }
}
