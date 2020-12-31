using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccsessLayer
{
    public class CustomerssDataAccessDetails
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        public DataTable FindCustomerDetails(int customer_ID)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM Customerss where customer_ID = @Customer_ID";
                using (SqlCommand cmd = new SqlCommand(sql,connection))
                {
                    cmd.Parameters.AddWithValue("@Customer_ID", customer_ID);
                        using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        ad.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }
    }
}
