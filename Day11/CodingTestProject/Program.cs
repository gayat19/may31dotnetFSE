using System;

namespace CodingTestProject
{
    class Program
    {

        int GetTheNonRepeatingNumber(int[] arr)
        {
            int result = 0;
            foreach (int item in arr)
            {
                result ^= item;
            }
            return result;
        }

        void CheckIfNumberIsPrime(int num)
        {
            int count = 0;
            if (num == 2 || num == 3 || num == 5 || num == 7)
            {
                count = 1;
            }
            else if (num % 2 == 0 || num % 3 == 0 || num % 5 == 0 || num % 7 == 0)
                count = 1;

            if (count != 1)
            {
                Console.WriteLine("The non-repeating number " + num + " is a prime number.");
            }
            else
            {
                Console.WriteLine("The non-repeating number " + num + " is not a prime number.");

            }
        }
        static void Main(string[] arr)
        {
            int[] numbers = { 13, 34, 8, 34, 70, 21, 21, 70, 8 };
            Program program = new Program();
            int number = program.GetTheNonRepeatingNumber(numbers);
            program.CheckIfNumberIsPrime(number);
            Console.ReadKey();
        }

      }
    
}
