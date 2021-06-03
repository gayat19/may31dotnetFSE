using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingRelationProject
{
    class Animal
    {
       
        public string Name { get; set; }
        public Animal()
        {
            Name = "Nothing yet";
        }
        public void Eat()
        {
            Console.WriteLine("Eats grass");
        }
        public void Sleep()
        {
            Console.WriteLine("zzzzzzzzzzzzzzzzz snooze");
        }
        public virtual void Move()
        {
            Console.WriteLine("Moves");
        }
        public override string ToString()
        {
            return "It is an animal. Yet to be named so the name is Nothing"; 
        }
        
    }
}
