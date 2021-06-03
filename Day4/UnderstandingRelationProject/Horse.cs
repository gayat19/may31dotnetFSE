using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingRelationProject
{
    class Horse : Animal
    {
        public Horse()
        {
            Name = "Horse";//Assigning the value
        }
        public override void Move()
        {
            Console.WriteLine("Tok tok tok.. tok tok tok");
        }
        public override string ToString()
        {
            return "It is an animal and we have a Horse. look :-)";
        }
    }
}
