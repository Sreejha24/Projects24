using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ADONET
{
    public class Program
    {
        static void Main(string[] args)
        {
            new ConnectToSQLServer().RecordReader();
            //string LoginId = Console.ReadLine();
            //string result = new ConnectToSQLServer().GetEmpNameByLoginId(LoginId);
            //Console.WriteLine(result);
            //string LoginId = Console.ReadLine();
            //new ConnectToSQLServer().RecordReaderByLoginId(LoginId);
            //new ConnectToSQLServer().RecordAdapter();
            //Execution execution = new Execution();
            //execution.Execute();
        }

    }
}
