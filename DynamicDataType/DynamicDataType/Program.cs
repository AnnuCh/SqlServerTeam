using System;

namespace DynamicDataType
{
    class Demo
    {
        dynamic Data = 12;
        public int Method(int A, int B)
        {
            return (A + B) * Data;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo Obj = new Demo();
            dynamic value1 = 10;
            dynamic value2 = 11;
            dynamic str = "Your result is:";
            Console.WriteLine(str +Obj.Method(value1,value2));
            Console.ReadLine();
        }
    }
}
