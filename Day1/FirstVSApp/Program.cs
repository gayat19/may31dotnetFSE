using System;

namespace FirstVSApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;
            num1 = 100;//Assignment operator
            num2 = 200;
            sum = num1 + num2;//Addition operator
            Console.WriteLine("The sum is " + sum);
            Console.WriteLine("The sum is {0}",sum);
            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine("Learn selection");
            if(num1==num2)
                Console.WriteLine("The numbers are equal");
            else if(num1>num2)
                Console.WriteLine($"{num1} which is num1 is greater");
            else
                Console.WriteLine($"{num2} which is num2 is greater");
            Console.WriteLine("Lear iteration");
            Console.WriteLine("For Loop");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("While");
            int count = 0;
            while (count<100)
            {
                Console.WriteLine(count);
                count = count + 10;
            }
            Console.WriteLine("Hello World!");
            Console.ReadKey();//Make the output window stay put
        }
    }
}
