using Microsoft.AspNetCore.Mvc;
using MyPizzaStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPizzaStoreApplication.Controllers
{
    public class CustomerController : Controller
    {
        static List<Customer> customers = new List<Customer>();
        public IActionResult Index()
        {
            return View(customers);
        }
        [HttpGet]
        public IActionResult RegisterCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterCustomer(Customer customer)
        {
            customers.Add(customer);
            return RedirectToAction("Index");
        }
    }
}
