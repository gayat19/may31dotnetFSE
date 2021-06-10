
using LearnEFProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEFProject.Services
{
    public class MAnageEmployees
    {
        SampleContext context;
        public MAnageEmployees()
        {
            context = new SampleContext();
        }
        public bool AddEmployee(Employee employee)
        {
            //adds it to the local dbset
            context.Employees.Add(employee);
            //makes the insert in to the database
            context.SaveChanges();
            return true;
        }
        public List<Employee> GetAllemployees()
        {
            //connect to database fetch all the emploeyes records, puts it in a list and gives us
            return context.Employees.ToList();
        }
    }
}
