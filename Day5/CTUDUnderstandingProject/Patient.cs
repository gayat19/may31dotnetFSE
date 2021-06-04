using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTUDUnderstandingProject
{
    /// <summary>
    /// Parient Model Class
    /// </summary>
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Remarks { get; set; }
        public string Phone { get; set; }
        public Patient()//Default constructor
        {

        }
        //Parameterized constructor
        public Patient(int id, string name, int age, string gender, string remarks, string phone)
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
            Remarks = remarks;
            Phone = phone;
        }
        public override string ToString()
        {
            return "Id : " + Id +
                "\nName : " + Name +
                "\nAge : " + Age +
                "\nGender : " + Gender +
                "\nPhone : " + Phone +
                "\nComments : " + Remarks;
        }
        /// <summary>
        /// Takes all the information about the patient from the console
        /// </summary>
        public void TakePatientDetailsFromUser()
        {
            int id,age;
            Console.WriteLine("Please enter the ID");
            //id = Convert.ToInt32(Console.ReadLine());
            //bool result = Int32.TryParse(Console.ReadLine(), out id);
            //Console.WriteLine(result);
            while (!Int32.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid entry for Id. Try again...");
            }
            Id = id;
            Console.WriteLine("Please enter your name");
            Name = Console.ReadLine();
            Console.WriteLine("Please select your gender Male/Female");
            Gender = Console.ReadLine();
            Console.WriteLine("Please neter your age");
            while (!Int32.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Invalid entry for Age. Try again...");
            }
            Age = age;
            Console.WriteLine("Please enter your phone number");
            Phone = Console.ReadLine();
            Console.WriteLine("Please enter any medical condition you want us to know");
            Remarks = Console.ReadLine();
        }
    }
}
