using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.DAL.Contracts
{
    public interface IEmployeeDAL
    {
        bool Save(Employee department);
        bool Delete(int id);
        List<Employee> GetAll();
        Employee GetEmployeeById(int id);

    }
}
