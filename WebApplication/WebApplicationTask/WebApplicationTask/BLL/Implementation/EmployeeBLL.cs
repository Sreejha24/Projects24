using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTask.BLL.Contracts;
using WebApplicationTask.DAL.Contracts;
using WebApplicationTask.Models;

namespace WebApplicationTask.BLL.Implementation
{
    public class EmployeeBLL : IEmployeeBLL
    {
        private readonly IEmployeeDAL _dal;
        public EmployeeBLL(IEmployeeDAL dal)
        {
            _dal = dal ?? throw new ArgumentNullException(nameof(dal));
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            return _dal.GetAll();
        }

        public Employee GetEmployeeById(int id)
        {
            return _dal.GetEmployeeById(id);
        }
        public bool Save(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
