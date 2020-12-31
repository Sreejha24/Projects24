using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.BLL.Contracts
{
    public interface IEmployeeBLL
    {
        bool Save(Employee employee);
        bool Delete(int id);
        List<Employee> GetAll();
        Employee GetEmployeeById(int id);

    }
}
