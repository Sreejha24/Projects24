using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.DAL.Contracts;
using WebApplication.Models;

namespace WebApplication.DAL.Implementation
{
    public class EmployeeDAL:IEmployeeDAL
    {
        private readonly CompanyContext context;
        public EmployeeDAL(CompanyContext company)
        {
            context = company ?? throw new ArgumentNullException(nameof(company));
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
        public List<Employee> GetAll()
        {
            return context.Employees.ToList();
        }
        public Employee GetEmployeeById(int id)
        {
            return context.Employees.Find(id);
        }
        public bool Save(Employee department)
        {
            throw new NotImplementedException();
        }
    }
}
