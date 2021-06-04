using System;

namespace CTUDUnderstandingProject
{
    class Program
    {
        /// <summary>
        /// Adds 2 numbers
        /// </summary>
        /// <param name="num1">int value1</param>
        /// <param name="num2">int value2</param>
        void Add(int num1,int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine($"The sum is {sum}");
        }
        /// <summary>
        /// Concats 2 strings
        /// </summary>
        /// <param name="str1">string value1</param>
        /// <param name="str2">string value2</param>
        void Add(string str1,string str2)
        {
            string final = str1+" " + str2;
            Console.WriteLine($"The result  is {final}");
        }
        static void Main(string[] args)
        {
            //new Program().Add("Hello", "World");
            //Patient patient = new Patient();
            //patient.TakePatientDetailsFromUser();
            //Console.WriteLine(patient);
            Clinic clinic = new Clinic();
            clinic.AddPatients();
            clinic.PrintChoiceForUser();
            Console.ReadKey();
        }
    }
}
