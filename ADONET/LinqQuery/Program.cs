using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace LinqQuery
{
    class Program
    {
        private static string connectionstring;
        private static SqlConnection conn;
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.Query();
            //new Class2().Query2();

            //    connectionstring = "Data Source=192.168.50.95;Initial Catalog=sprathipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            //    conn = new SqlConnection(connectionstring);
            //    var EmployeeDetails = Linq();
            //    //foreach (var item in EmployeeDetails)
            //    //{
            //    //    Console.WriteLine(item.EmpName + "                                     \t  ||    " + item.LoginId);

            //    //}
            //    //var data = EmployeeDetails.Where(d => d.EmpName.Equals("Sreejha"));
            //    //var data = EmployeeDetails.Where(d=>d.EmpName.StartsWith("S"));
            //    // var data = EmployeeDetails.Where(d=>d.EmpName.StartsWith("K") || d.LoginId.Equals("TP8"));
            //    // var data = EmployeeDetails.Where(d=>d.EmpName.StartsWith("K") && d.EmpName.EndsWith("a"));
            //    //var data = EmployeeDetails.Where(d=>d.EmpName.Contains("R"));
            //    //var data = EmployeeDetails.Where(d => d.EmpName.StartsWith("S")).OrderBy(d => d.LoginId).ThenBy(d=>d.EmpName);
            //    //var data = EmployeeDetails.Where(d => d.LoginId.Equals("TP9")).OrderByDescending(d => d.EmpName).ThenBy(d => d.LoginId);
            //    foreach (var item in data)
            //    {


            //        Console.WriteLine(item.EmpName + "                                     \t  ||    " + item.LoginId);

            //    }

            //}

            //public static IList<Employee> Linq()
            //{
            //    DataTable dt = new DataTable();
            //    var sql = "SELECT * FROM Employees11122020";

            //    using (SqlCommand cmd = new SqlCommand(sql, conn))
            //    {
            //        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
            //        {
            //            dataAdapter.Fill(dt);
            //        }
            //    }

            //    IList<Employee> employee = new List<Employee>();
            //    foreach (DataRow row in dt.Rows)
            //    {
            //        var emp = new Employee()
            //        {
            //            LoginId = row["LoginId"].ToString(),
            //            EmpName = row["EmpName"].ToString()
            //        };
            //        employee.Add(emp);
            //    }
            //    return employee;
            //}
        }
    }
}
