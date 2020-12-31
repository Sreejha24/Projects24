using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ADONET
{
    public class ConnectToSQLServer
    {
        private string connectionstring;
        private SqlConnection conn;
        private DataSet dataSet;
        private SqlDataAdapter dataAdapter;
        public ConnectToSQLServer()
        {
            connectionstring = "Data Source=192.168.50.95;Initial Catalog=sprathipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            conn = new SqlConnection(connectionstring);
            dataSet = new DataSet();
        }
        /// <summary>
        /// Read all Employee records from database and print on the console.
        /// </summary>
        public void RecordReader()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT EmpName,LoginId FROM Employees11122020", conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Console.WriteLine(dataReader["EmpName"] + " \t " + dataReader["LoginId"]);
            }
            conn.Close();
        }
        /// <summary>
        /// Show single employee details for the parameter passed in
        /// </summary>
        /// <param name="LoginId"></param>
        /// <returns></returns>
        public void RecordReaderByLoginId(string LoginId)
        {
            SqlCommand cmd = new SqlCommand("SELECT EmpName,LoginId FROM Employees11122020", conn);
            cmd.Parameters.AddWithValue("@LoginId", LoginId);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                Console.WriteLine($"Employee Name:{dataReader["EmpName"]}");
                Console.WriteLine($"Login Id:{dataReader["LoginId"]}");
            }
            conn.Close();
        }
        /// <summary>
        /// Get Emplyee name for the employee number passed in as a parameter
        /// </summary>
        /// <param name="LoginId"></param>
        /// <returns></returns>
        public string GetEmpNameByLoginId(string LoginId)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT EmpName from Employees11122020 where LoginId = @LoginId", conn);
            cmd.Parameters.AddWithValue("@LoginId", LoginId);
            var EmpName = cmd.ExecuteScalar();
            conn.Close();
            return Convert.ToString(EmpName);
        }
        /// <summary>
        /// In Visual Studio, inside DataSetDemo.cs file, one task has been given. Work on that as well.
        /// </summary>
        public void RecordAdapter()
        {
            conn.Open();
            dataAdapter = new SqlDataAdapter("SELECT EmpName,LoginId from Employees11122020", conn);
            dataAdapter.Fill(dataSet, "Employees11122020");
            dataAdapter = new SqlDataAdapter("SELECT DeptName,DeptID,EmpID from Department11122020", conn);
            dataAdapter.Fill(dataSet, "Department11122020");
            foreach (DataRow row in dataSet.Tables["Employees11122020"].Rows)
            {
                Console.WriteLine(row["EmpName"] + " | " + row["LoginId"]);
            }
            foreach (DataRow row1 in dataSet.Tables["Department11122020"].Rows)
            {
                Console.WriteLine(row1["DeptID"] + " | " + row1["DeptName"] + " | " + row1["EmpID"]);
            }
            conn.Close();
        }
    }
}
