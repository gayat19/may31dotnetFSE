using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEFProject.Models
{
    public class Employee
    {
        //Id tells the ORM that it is teh primary key.
        ////Also if it is integer it will be an identity automatically
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date_Of_Birth { get; set; }

    }
}
