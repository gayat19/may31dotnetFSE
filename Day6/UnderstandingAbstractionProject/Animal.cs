using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingAbstractionProject
{
    public abstract class Animal
    {
        public abstract void Look();//pure virtual method. It has too be overriden in teh derived class
        public virtual void Eat()//only virtual methods can be overriden
        {
            Console.WriteLine("Eat eat.. munch munch");
        }
        public void Sleep()
        {
            Console.WriteLine("zzzzzzzzzzzzzz");
        }
    }
}
