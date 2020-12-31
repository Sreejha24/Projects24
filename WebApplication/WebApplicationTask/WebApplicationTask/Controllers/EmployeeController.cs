using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTask.BLL.Contracts;

namespace WebApplicationTask.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeBLL _empbll;

        public EmployeesController(IEmployeeBLL bll)
        {
            _empbll = bll ?? throw new ArgumentNullException(nameof(bll));
        }

        public IActionResult Index()
        {
            var employees = _empbll.GetAll();
            return View(employees);
        }
    }
}