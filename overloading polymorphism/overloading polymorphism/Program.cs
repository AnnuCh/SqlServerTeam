using System;
    namespace polymorphismExample
{
    public class Numbers
    {
        public void addition(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void addition(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
    }

    public class Display
    {
        static void Main(string[] args)
        {
            Numbers obj = new Numbers();
            obj.addition(3, 7);
            obj.addition(9, 4, 2);
            Console.ReadKey();
        }
    }
}