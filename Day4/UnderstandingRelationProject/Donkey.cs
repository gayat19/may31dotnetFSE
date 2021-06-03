using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingRelationProject
{
    class Donkey : Animal
    {
        public Donkey()
        {
            Name = "Donkey";
        }
        public override void Move()
        {
            Console.WriteLine("Tok a tok .......... tok a tok..........");
        }
        public override string ToString()
        {
            return "It is an animal. But it is specialized as a Donkey now...";
        }
    }
}
