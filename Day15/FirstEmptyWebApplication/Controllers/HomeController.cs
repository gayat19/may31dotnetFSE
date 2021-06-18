using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstEmptyWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from controller";
        }
        [ActionName("Sweet")]
        public string GivingLongMethodNamesMakesItDifficultForTheEndUser()
        {
            return "Another method";
        }
        public ActionResult ViewCustomerData()
        {
            ViewData["CustomerName"] = "ABC";
            ViewData["CustomerAge"] = 31;
            ViewData["CustomerSalary"] = 12334.4f;
            ViewData["CustomerPet"] = new object();
            return View();
        }
    }
}
