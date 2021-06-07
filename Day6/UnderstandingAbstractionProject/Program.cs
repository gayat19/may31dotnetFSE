using System;

namespace UnderstandingAbstractionProject
{
    class Program
    {
        void UnderstandingOperatorOverloading()
        {
            Classroom cr1, cr2;
            cr1 = new Classroom(101,20,"ABC");//create new object
            cr2 = new Classroom();
            cr2.Id = 102;
            cr2.Strength = 15;
            cr2.Incharge = "ghj";
            Classroom cr3 = cr1 + cr2;
            Console.WriteLine("The sum using the + operator of ");
            Console.WriteLine(cr1);
            Console.WriteLine("+");
            Console.WriteLine(cr2);
            Console.WriteLine("----------------------------------");
            Console.WriteLine(cr3);

        }
        static void Main(string[] args)
        {
            new Program().UnderstandingOperatorOverloading();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
