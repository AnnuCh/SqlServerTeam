
    using System;
    
    namespace Annu
    {
        public class Employee
        {
            public string Firstname;
            public string Lastname;
            public string Email;
        //    public void PrintFullName()
        //    {
        //    //Console.WriteLine(Firstname + " " + Lastname);
        //    //Console.WriteLine(Email);


        //    Console.ReadKey();
        //} 
        }
        public class FullTimeEmployee : Employee
        {
            public float YearlySalary;
        Console.WriteLine(YearlySalary);
        }
        public class PartTimeEmployee : Employee
    {
            public float HourlyRate;
        public void PrintFullName()
        {
            Console.WriteLine(Firstname + " " + Lastname);         
            Console.WriteLine(Email);
            
            Console.WriteLine(HourlyRate);
            Console.ReadKey();
        }
    }
    public class program
    {
        public static void Main()
        {
            //FullTimeEmployee FTE = new FullTimeEmployee();
            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.Firstname = "Annu";
            PTE.Lastname = "Choubey";
            PTE.Email = "annu@gmail.com";
            PTE.YearlySalary = 555555;
          
            PTE.HourlyRate = 550.0f;
            PTE.PrintFullName();
           
   
            //Console.WriteLine();
        }
        }
    }





