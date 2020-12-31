using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class EmployeeDAL
    {

        static string _connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        public DataTable FindEmployees(string empId)
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                string sql = "SELECT * FROM Employees WHERE EmpId = @empId";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@empId", empId);
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        ad.Fill(table);
                    }
                }
            }
            return table;
        }

    }
}
