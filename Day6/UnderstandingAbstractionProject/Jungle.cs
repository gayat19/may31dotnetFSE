using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingAbstractionProject
{
    class Jungle
    {
        public Jungle()
        {
            Animal dog = new Dog();
            dog.Eat();
            dog.Look();
            dog.Sleep();
        }
        static void Main(string[] a)
        {
            new Jungle();
            Console.ReadKey();
        }
    }
}
