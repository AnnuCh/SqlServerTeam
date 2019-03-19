using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Models
{
    public class Class1
    {



        public static void GetData(clsEmpDetails emp)
        {

            string connectionString = "Data Source=BHANU-IMMIRAGRA;Initial Catalog=annu;Integrated Security=True";               
            //"Server=tcp:company.database.windows.net,1433;
//nitial Catalog=company;Persist Security Info = False;
         //   User ID = Azure;
           // Password = Annuchoubey@17; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; "
            //            System.Configuration.ConfigurationManager.
            //ConnectionStrings["conStrDetails"].ConnectionString;
            //        string connectionString = ConfigurationManager.ConnectionStrings["conStrDetails"].ConnectionString;

            //MessageBox.Show("GetData method Hit");
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                //SqlDataAdapter Adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand();

                command.Connection = connection;
                command.CommandTimeout = 10000;

                command.CommandType = CommandType.Text;
                //command.CommandText = StoredProcedureName;

                string query = "insert into tblEmployeeDetails (EmployeeName,Gender,Salary,Skillset,Mobile,email,EmpTypeID) values ('" + emp.EmployeeName + "','" +
                    emp.Gender + "'," + emp.Salary + ",'" + emp.Skillset + "'," + emp.Mobile + ",'" + emp.email + "'," + emp.EmpTypeID + ")";
                command.CommandText = query;

                int i = command.ExecuteNonQuery();

                //SqlParameter param = new SqlParameter("@id", txtSearch.Text);
                //cmd.Parameters.Add(param);

                //if (Params != null)
                //{
                //    command.Parameters.AddRange(Params);
                //}

                //Adapter.SelectCommand = command;
                //DataSet ds = new DataSet();

                //Adapter.Fill(ds);


                //return ds;
            }
            catch (Exception ex)
            {
                // ErrorLog(StoredProcedureName, new SqlParameter[] {
                //    new SqlParameter("@ErrorCode","0"),
                //    new SqlParameter("@ErrorMessage",ex.Message.ToString()),
                //    new SqlParameter("@ErrorInterface",ex.GetType().ToString()),
                //    new SqlParameter("@ErrorPage","sqlHelper.GetData"),
                //    new SqlParameter("@UserInfo",Environment.UserName),
                //});

                //DataSet da = new DataSet();
                //return (da);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}