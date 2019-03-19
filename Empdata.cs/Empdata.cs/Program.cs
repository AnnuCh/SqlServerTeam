using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Empdata.cs
{
  
   
        class Employee
        {

           
            public string EmpName;
        public int EmpID;
        public int Age;
            public string Sex;
            public string JobLocation;
            public string JoiningDate;

            public void InsertEmpData()
            {
            string connectionString = "Server=tcp:company.database.windows.net,1433; Initial Catalog = company; Persist Security Info = False; User ID = azure; Password =Annuchoubey@17; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30";

            SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();


                SqlCommand command = new SqlCommand();

                command.Connection = connection;
                command.CommandTimeout = 10000;

                command.CommandType = CommandType.Text;

                string query = "insert into EmployeeInfo(EmpID,EmployeeName,Age,Sex,JobLocation,JoiningDate) values('" + EmpID + "','" +
                    EmpName + "','" + Age + "','" + Sex + "','" + JobLocation + "'," + JoiningDate + ")";
                command.CommandText = query;

                int i = command.ExecuteNonQuery();
                if (i == 1)
                {
                    Console.WriteLine("Details inserted Successfully");
                }
                else
                {
                    Console.WriteLine("Failed");
                }
                Console.ReadLine();
                connection.Close();


            }

            static void Main(string[] args)
            {
                Employee empobj = new Employee();
                Console.WriteLine("Enter employee Id:");
                empobj.EmpID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter employee Name:");
                empobj.EmpName = Console.ReadLine();
                Console.WriteLine("Enter employee Age:");
                empobj.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter sex:");
                empobj.Sex = Console.ReadLine();
                Console.WriteLine("Enter employee Job location:");
                empobj.JobLocation = Console.ReadLine();
                Console.WriteLine("Enter employee  Joining date:");
                empobj.JoiningDate = Console.ReadLine();
                empobj.InsertEmpData();


            }
        }

    }