using System;

namespace polymorphismExample
{
    public class parentClass
    {
        public virtual void Display()
        {
            Console.WriteLine("Hello! My name is Annu!");
        }
    }

    public class childClass : parentClass
    {
        public override void Display()
        {
            Console.WriteLine("Hello! Nice to meet you!");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            parentClass obj = new childClass();
            obj.Display();
          Console.ReadKey();
        }
    }
}