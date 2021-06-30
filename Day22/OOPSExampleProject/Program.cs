using System;

namespace OOPSExampleProject
{
    interface ILivingObject
    {
        void Breathe();
    }
    interface ILive :ILivingObject
    {
        void Eat();
        void Sleep();
       
    }
    class Animal : ILive
    {
        public void Breathe()
        {
            Console.WriteLine("Take in O2 and give out CO2");
        }

        public void Eat()
        {
            Console.WriteLine("Eat");
        }

        public void Sleep()
        {
            Console.WriteLine("sdjbsdk");
        }
    }
    class Tree : ILivingObject
    {
        public void Breathe()
        {
            Console.WriteLine("Take in CO2 and give out O2");
        }

       
    }
    class MyClass
    {
        public virtual void Sample() { }

    }
    class YourClass:MyClass
    {
        public override void Sample()
        {

        }
    }
    class OurClass : YourClass
    {
        public sealed override void Sample()
        {

        }
    }
    class EveryonerClass : OurClass
    {
        public override void Sample()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
