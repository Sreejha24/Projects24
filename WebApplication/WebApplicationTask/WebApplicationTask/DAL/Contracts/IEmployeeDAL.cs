using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTask.Models;

namespace WebApplicationTask.DAL.Contracts
{
    public interface IEmployeeDAL
    {
        bool Save(Employee department);
        bool Delete(int id);
        List<Employee> GetAll();
        Employee GetEmployeeById(int id);

    }
}
