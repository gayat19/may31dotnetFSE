using LearnEFProject.Models;
using LearnEFProject.Services;
using System;
using System.Collections.Generic;

namespace LearnEFProject
{
    class Program
    {
        MAnageEmployees manageEmployees;
        public Program()
        {
            manageEmployees = new MAnageEmployees();
        }
        Employee TakeEmployeeDetails()
        {
            Employee employee = new Employee();
            Console.WriteLine("Please enter the employee name");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Please enter the employee date of birth");
            employee.Date_Of_Birth = Convert.ToDateTime(Console.ReadLine());
            return employee;
        }
        void CreateEmployee()
        {
            Employee employee = TakeEmployeeDetails();
            manageEmployees.AddEmployee(employee);
        }
        void PrintEmployees()
        {
            List<Employee> employees = manageEmployees.GetAllemployees();
            foreach (var item in employees)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Date_Of_Birth);
                Console.WriteLine("--------------------------");
            }

        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.CreateEmployee();
            program.PrintEmployees();
            Console.WriteLine("Hello World!");
        }
    }
}
