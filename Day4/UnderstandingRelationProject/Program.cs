using System;

namespace UnderstandingRelationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Company company = new Company();
            //Console.WriteLine("Hello World!");
            //Mobile iPhone = new Mobile();
            SmartPhone iPhone = new SmartPhone();
            iPhone.MyApp = "Excel";
            iPhone.Ring();
            Console.WriteLine("Mobile color is "+iPhone.Color);
            Console.ReadKey();
        }
    }
}
