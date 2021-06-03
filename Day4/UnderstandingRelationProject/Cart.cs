using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingRelationProject
{
    class Cart
    {
        void PullCart(Animal animal)
        {
            animal.Eat();
            animal.Move();//overriden method
            animal.Sleep();
        }
        static void Main(string[] a)
        {
            Cart cart = new Cart();
            Animal animal = new Donkey();
            cart.PullCart(animal);
            Console.WriteLine(animal);
            Console.ReadKey();
        }
    }
}
