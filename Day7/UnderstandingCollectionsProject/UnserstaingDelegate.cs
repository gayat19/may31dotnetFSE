using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingCollectionsProject
{
    class UnserstaingDelegate
    {
        //Creating type to reffrence methods that gives nothing in return and takes 2 int parameters
        public delegate void MyDelegate(int num1, int num2);
        //Creating reff to the delegate type
        MyDelegate calDelAdd,calDelProd,calDelSub,calDelDiv;
        public UnserstaingDelegate()
        {
            //takes method as parameter
            //only those methods which comply with the type def
            calDelAdd = new MyDelegate(Add);
            calDelProd = new MyDelegate(Product);
            //anonymous method ref by delegate
            calDelSub = delegate (int n1, int n2)
            {
                Console.WriteLine("The result is "+(n1-n2));
            };
            //Lambda expression
            calDelDiv =  (n1, n2)=>Console.WriteLine("The result is " + (n1 / n2));
            //call by passing a lambda directly
            CallMethods((n1, n2) => Console.WriteLine("The result is " + (n1 % n2)));
            //Action is a pre defined delegate type
            Action<int, int> myDel = (n1, n2) => Console.WriteLine(n1+n2);
            CallMethodsAnother(myDel);
            Func<int, int,int> addDel = (n1, n2) => n1 + n2;
            int result = addDel(20, 30);
            Console.WriteLine(result);
            int num = 100;
            Predicate<int> checkPredicate = (n1) => n1 > num;
            Console.WriteLine(checkPredicate(50));
            //CallMethods(calDelDiv);
        }
        void Add(int n1, int n2)
        {
            int sum = n1 + n2;
            Console.WriteLine($"The sum is {sum}");
        }
        void Product(int n1, int n2)
        {
            int sum = n1 * n2;
            Console.WriteLine($"The product is {sum}");
        }
        void CallMethodsAnother(Action<int,int> methodRef)
        {
            methodRef(100, 10);
        }
        void CallMethods(MyDelegate methodRef)
        {
            methodRef(100, 10);
        }

        static void Main(string[] arg)
        {
            new UnserstaingDelegate();
            Console.ReadKey();
        }
    }
}
