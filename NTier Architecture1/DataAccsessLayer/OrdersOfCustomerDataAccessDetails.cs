using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccsessLayer
{
    public class OrdersOfCustomerDataAccessDetails
    {
        static string connectionstring = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public DataTable FindOrders(int customer_ID)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string sql = "SELECT * FROM OrdersOfTheCustomers WHERE customer_ID = @Customer_ID";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Customer_ID", customer_ID);
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
