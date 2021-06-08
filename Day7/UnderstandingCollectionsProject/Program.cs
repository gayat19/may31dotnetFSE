using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UnderstandingCollectionsProject
{
    class Program
    {
        //ArrayList numbers = new ArrayList();//collection
        //List<double> numbers = new List<double>();//generic

        public Program()
        {
           // numbers.Add(100);
           // numbers.Add(123.43);
           // numbers.Add(123.3f);
           //// numbers.Add("Hello");//will not allow coz of typesafty
           // double sum = 0;
           // foreach (var item in numbers)
           // {
           //     sum = sum +item;
           // }
           // Console.WriteLine($"Sum is {sum}");
        }

        void UnderstandingList()
        {
            List<string> names = new List<string>();
            names.Add("Ramu");
            names.Add("Jill");
            names.Add("ABC");
            names.Add("Jasmine");
            names.Sort();//Will sort the strings in ascending order
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("is the name Jill in the list??? "+names.Contains("Jill"));
            List<Employee> employees = new List<Employee>();//creating a list of employees
            Employee emp1 = new Employee(101, "Ramu", 21);//calling teh overloaded constructor
            Employee emp2 = new Employee();//default constructor
            emp2.Id = 102;
            emp2.Name = "Jill";
            emp2.Age = 32;
            Employee emp3 = new Employee
            {
                Id = 103,
                Name = "Jasmine",
                Age = 22
            };//Assiging properties while creating an object
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(new Employee(104, "Rose", 18));//adding an object directly
            //employees.Sort(sort by Name)
            employees.Sort((e1, e2) => e1.Age.CompareTo(e2.Age));
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
            //if(new Employee(101,"ABC",21).Equals(new Employee(101,"ABC",21)))
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");
            if (emp1.Equals(emp2))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            Console.WriteLine("is the employee Ramu in the list??? " + employees.Contains(new Employee(104, "Rose", 18)));
            Console.WriteLine("Enter the employee id to be found");
            int id = Convert.ToInt32(Console.ReadLine());
            Employee employee = employees.Find(emp => emp.Id == id);

            Console.WriteLine(employee);
        }
        static void Main(string[] args)
        {
            Program progtam = new Program();
            progtam.UnderstandingList();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
