using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UnderstandingService.Models;

namespace UnderstandingService.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                int num1, num2, res;
                num1 = 100;
                num2 = 0;
                res = num1 / num2;
            }
            catch (DivideByZeroException dbz)
            {
                _logger.LogError("Dinominator is 0 " + DateTime.Now.ToString());
            }
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("All good. Page rendered "+DateTime.Now.ToString());
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
