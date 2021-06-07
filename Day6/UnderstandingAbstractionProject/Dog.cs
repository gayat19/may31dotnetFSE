using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingAbstractionProject
{
    public class Dog : Animal
    {
        //public override void Eat()
        //{
        //    Console.WriteLine("Loves pedigree");
        //}
      
        public override void Look()
        {
            Console.WriteLine("Has 4 legs and floppy ears");
        }
    }
}
