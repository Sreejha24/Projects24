using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace LinqQuery
{
    public class Class2
    {
        private static string connectionstring;
        private static SqlConnection conn;
        public void Query2()
        {
            connectionstring = "Data Source=192.168.50.95;Initial Catalog=sprathipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            conn = new SqlConnection(connectionstring);
            var EmployeeDetails = Employees();

            var Emp = from Employees11122020 in EmployeeDetails where Employees11122020.EmpName.StartsWith("S") select Employees11122020;
            //foreach (var item in EmployeeDetails)
            //{
            //    Console.WriteLine(item.EmpName + "                                     \t  ||    " + item.LoginId);

            //}
        }
        IList<Employee> Employees()
        {
            string sql = "SELECT * FROM Employees11122020 ORDER BY EmpName ASC";
            using (DataTable dataTable = new DataTable())
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                        {
                            dataAdapter.Fill(dataTable);
                        }
                        conn.Close();
                    }
                    IList<Employee> employees = new List<Employee>();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var emp = new Employee()
                        {
                            LoginId = row["LoginId"].ToString(),
                            EmpName = row["EmpName"].ToString()
                        };
                        employees.Add(emp);
                    }
                    return employees;
                }
            }
        }
    }
}
