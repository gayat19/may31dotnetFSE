using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnderstandingDBConProject.Models;

namespace UnderstandingDBConProject.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly CompanyContext _context;

        public EmployeeController(CompanyContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Employee> employees = _context.Employees.ToList();
            return View(employees);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
