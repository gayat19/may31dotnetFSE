using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstEmptyWebApplication.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "Jim";
            ViewData["Age"] = 29;
            ViewData["DOB"] = new DateTime(1999, 07, 07);
            ViewData["Phone"] = "+1(010)23456789";
            return View();
        }
    }
}
