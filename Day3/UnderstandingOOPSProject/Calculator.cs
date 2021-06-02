using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingOOPSProject
{
    //default access for all the stuff inside the class is private
    class Calculator
    {
        //All instance meber will be initialized to base value
        int num1, num2;//instance member

        /// <summary>
        /// Method o take 2 numbers from user
        /// </summary>
        void TakeInput()
        {
            Console.WriteLine("Please enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// The method will call the TakeInput Method for getting the numbers and sum them up
        /// </summary>
        public void Add()
        {
            TakeInput();
            int sum = num1 + num2;//sum is a local variable
            PrintResult(sum);
        }

        /// <summary>
        /// The method will call the TakeInput Method for getting 2 numbers and calculate the product
        /// </summary>
        public void Multiply()
        {
            TakeInput();
            int product = num1 * num2;
            PrintResult(product);
        }
        /// <summary>
        /// Used to print the result.
        /// </summary>
        /// <param name="result">It is the result that needs to be printed</param>
        void PrintResult(int result)
        {
            Console.WriteLine($"The result is {result}");
        }

        /// <summary>
        /// Default constructor. Initializes teh valuesof num1 and num2 to 0
        /// </summary>
        public Calculator()
        {
            num1 = 0;
            num2 = 0;
        }
    }
}
