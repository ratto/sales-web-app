using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebApp.Models;

namespace SalesWebApp.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department { Id = 1, Name = "Eletronics" });
            departments.Add(new Department { Id = 2, Name = "Mechanics" });

            return View(departments);
        }
    }
}