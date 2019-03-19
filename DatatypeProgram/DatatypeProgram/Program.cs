using System;

namespace DatatypeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "Geeks";
            s+= "for";
            s = s + "Geeks";
            Console.WriteLine(s);

            object obj;
            obj = 20;
            Console.WriteLine(obj);
            Console.WriteLine(obj.GetType());
            Console.ReadLine();
        }
    }
}
