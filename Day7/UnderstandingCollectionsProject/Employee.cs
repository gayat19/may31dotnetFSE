using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingCollectionsProject
{
    //Implement the IComparable interface so that the objtes of the employee calss become sortable
    class Employee //:IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Employee()
        {

        }

        public Employee(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        //checking equality
        public override bool Equals(object obj)
        {
            //float f1 = 10.2f;
            //int num1 = (int)f1;//casting float to int type
            Employee emp1 = this;//this is the implicit reff to the current object
            Employee emp2 = (Employee)obj;//casting object to Employee type
            if (emp1.Id == emp2.Id && emp1.Name == emp2.Name && emp1.Age == emp2.Age)
                return true;
            return false;
        }
        //for printing
        public override string ToString()
        {
            return "Id " + Id + " Name " + Name + " Age " + Age;
        }
        //for sorting
        //should return either 0 or -1 or 1
        //public int CompareTo(Employee other)
        //{
        //    //if (this.Id > other.Id)
        //    //    return -1;
        //    //else if (this.Id < other.Id)
        //    //    return 1;
        //    //else
        //    //    return 0;
        //    return this.Name.CompareTo(other.Name);
        //}
    }
}
