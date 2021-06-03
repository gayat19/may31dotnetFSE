using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingRelationProject
{
    class Company
    {
        //public string Name;
        //public string Description;
        //public Person Employee;
        public string Name { get; set; }
        public string Description { get; set; }
        public Person Employee { get; set; }
        public Company()
        {
            Employee = new Person();
            Employee.Name = "ABC";
            Employee.Age = 45;
            //Employee.code = 1111; not accessaable
            //Console.WriteLine("Please enter a number");
            //Employee.Check = Convert.ToInt32(Console.ReadLine());
            //Employee.PrintCheck();
        }
    }
}
