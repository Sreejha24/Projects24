using System;
using System.Data;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class EmployeeAddressDetails
    {
        public DataSet GetEmployeeAddressDetails(string empId)
        {
            EmployeeDAL dal = new EmployeeDAL();
            var table = dal.FindEmployees(empId);
            

            AddressesDAL addressesDAL = new AddressesDAL();
            var tableAddress = addressesDAL.FindAddress(empId);
            
          
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(table);
            dataSet.Tables.Add(tableAddress);
            return dataSet;
        }
    }
}
