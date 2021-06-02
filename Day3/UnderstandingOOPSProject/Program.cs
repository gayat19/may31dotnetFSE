using System;

namespace UnderstandingOOPSProject
{
    class Program
    {
        /// <summary>
        /// The default constructor. Just for learning
        /// </summary>
        public Program()
        {
            Console.WriteLine("Program class contructor");
        }

        /// <summary>
        /// This is the entry point of the application
        /// </summary>
        /// <param name="args">It is an array of string</param>
        static void Main(string[] args)
        {
            //Creating an object
            //Program program = new Program();//type ref = new Constructor()
            Calculator calculator  = new Calculator();
            calculator.Add();
            Console.ReadKey();
        }
       
    }
}
