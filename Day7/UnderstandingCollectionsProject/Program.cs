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
            names[0] = "Welcome";
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
            //Picks every item in collection and does teh comparison. The first matching result is returend
            //If no match is found returns null
            Employee employee = employees.Find(emp => emp.Id == id);

            Console.WriteLine(employee);
        }
        //set will not allow duplicates
        void UnderstandingSet()
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(100);
            set.Add(200);
            set.Add(100);
            set.Add(90);
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
        void UnderstandingDictionary()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(101, "Ramu");
            myDictionary.Add(102, "Jill");
            myDictionary.Add(103, "ABC");
            myDictionary.Add(104, null);
            //myDictionary.Add(102, "Jill");
            Console.WriteLine("Does the collection contain teh key 105?? "+myDictionary.ContainsKey(105));
            Console.WriteLine("To access the value of the 102 "+myDictionary[102]);
            Console.WriteLine("----------------------");
            foreach (var item in myDictionary.Keys)
            {
                Console.WriteLine(myDictionary[item]);
            }
        }

        //LIFO-> Push,Pop,Peek
        void UnderstandStack()
        {
            Stack<Employee> employeeStack = new Stack<Employee>();
            employeeStack.Push(new Employee() { Id = 101, Name = "ABC", Age = 21 });
            employeeStack.Push(new Employee(102, "XYZ", 30));
            employeeStack.Push(new Employee());
            Console.WriteLine("Just to check the next retrivable item "+employeeStack.Peek());
            Console.WriteLine("The size of the stack before the for loop is "+employeeStack.Count);
            foreach (var item in employeeStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("The size of the stack after the for loop is " + employeeStack.Count);
        }
        static void Main(string[] args)
        {
            Program progtam = new Program();
            progtam.UnderstandStack();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
