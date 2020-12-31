using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTask.DAL.Contracts;
using WebApplicationTask.Data;
using WebApplicationTask.Models;

namespace WebApplicationTask.DAL.Implementation
{
    public class EmployeeDAL : IEmployeeDAL
    {
        private readonly ApplicationDbContext context;
        public EmployeeDAL(ApplicationDbContext company)
        {
            context = company ?? throw new ArgumentNullException(nameof(company));
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
        public List<Employee> GetAll()
        {
            return context.Employee.ToList();
        }
        public Employee GetEmployeeById(int id)
        {
            return context.Employee.Find(id);
        }
        public bool Save(Employee department)
        {
            throw new NotImplementedException();
        }
    }
}
