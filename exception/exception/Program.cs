using System;
namespace exception
{
    class MyClient
    {
        public static void Main()
        {
            int x = 0;
            int div = 0;
            try
            {
              div = 100 / x;
                Console.WriteLine(div);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("can't divide by zero");
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
            Console.WriteLine($"Result is {div}");
            Console.ReadKey();
        }
    }
        }
    
