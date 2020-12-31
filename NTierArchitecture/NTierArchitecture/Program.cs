using Microsoft.SqlServer.Server;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using BusinessAccessLayer;

namespace NTierArchitecture
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter EmpId to see the details:");
            var empId = Console.ReadLine().ToString();
            DataSet dataSet = new DataSet();
            try
            {
                dataSet = new EmployeeAddressDetails().GetEmployeeAddressDetails(empId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured. " + ex.ToString());
            }

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                Console.WriteLine(row["EmpId"] + " | " + row["Name"] + " | " + row["Salary"]);
            }

            foreach (DataRow row in dataSet.Tables[1].Rows)
            {
                Console.WriteLine(row["Address1"] + " | " + row["Address2"] + " | " + row["City"]);
            }
        }


    }
}
