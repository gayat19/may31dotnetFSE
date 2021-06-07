using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingAbstractionProject
{
    class Classroom
    {
        public int Id { get; set; }//Identifier
        public int Strength { get; set; }

        public string Incharge { get; set; }

        public Classroom()//Default Empty constructor
        {

        }

        public Classroom(int id, int strength, string incharge)//parameterized constuctor
        {
            Id = id;
            Strength = strength;
            Incharge = incharge;
        }
        public static Classroom operator+(Classroom c1,Classroom c2)//Overloaded + operator
        {
            Classroom cr = new Classroom();
            cr.Id = c1.Id + c2.Id;
            cr.Incharge = c2.Incharge;
            cr.Strength = c1.Strength + c2.Strength;
            return cr;
        }
        public override string ToString()
        {
            return "Class ID" + Id + " strength " + Strength + " Incharge " + Incharge;
        }
    }
}
