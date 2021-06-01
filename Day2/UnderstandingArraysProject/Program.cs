using System;

namespace UnderstandingArraysProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Program();//creating the object
            //Program program = new Program();//Creatingthe object and provide reff to it
            Console.WriteLine("Please enter the size of the array you wish to create");
            int length = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[length];
            //Console.WriteLine("The upper bound of teh array "+words.GetUpperBound(0));
            int counter = 0;
            string strChoice = "";
            Console.WriteLine("Please enter the words and enter  No if you wish to exit.");
            Console.WriteLine($"You can enter teh maximum of {length} words");
            do
            {
                strChoice = Console.ReadLine();
                words[counter] = strChoice;
                counter++;//post increment operator
                //Console.WriteLine(strChoice);

            } while (strChoice != "No" && counter<= words.Length);
            Console.WriteLine("You have entered teh following words");
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            Console.ReadKey();
        }
    }
}
