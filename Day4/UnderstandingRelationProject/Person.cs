using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingRelationProject
{
    class Person
    {
        //public string Name;
        //public int Age;
        public int Age { get; set; }
        public string Name { get; set; }
        protected int code { get; set; }
        int check;
        string phone;
        public string Phone
        {
            get
            {
                return phone.Substring(0, 5) + "*****";
            }
            set
            {
                phone = value;
            }
        }
        public int Check
        {
            get
            {
                return check;
            }
            set
            {
                check = value*100;
            }
        }
        public void PrintCheck()
        {
            Console.WriteLine("check now is "+check);
        }
    }
}
