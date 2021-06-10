
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

        public Employee GetEmployee(int id)
        {
            Employee employee = context.Employees.Where(emp => emp.Id == id).FirstOrDefault();
            return employee;
        }

        public bool EditEmployee(int id,Employee employee)
        {
            Employee myEmployee = GetEmployee(id);
            if(employee!=null)
            {
                myEmployee.Name = employee.Name;
                myEmployee.Date_Of_Birth = employee.Date_Of_Birth;
                //context.Employees.Update(myEmployee);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public List<Employee> GetAllemployees()
        {
            //connect to database fetch all the emploeyes records, puts it in a list and gives us
            return context.Employees.ToList();
        }

        internal bool RemoveEmployee(int id)
        {
            Employee myEmployee = GetEmployee(id);
            context.Employees.Remove(myEmployee);
            context.SaveChanges();
            return true;
        }
    }
}
