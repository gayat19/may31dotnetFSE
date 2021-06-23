using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPizzaStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPizzaStoreApplication.Controllers
{
    public class PizzaController : Controller
    {
        static List<Pizza> pizzas = new List<Pizza>()
        {
            new Pizza(){ 
                Id=101,
                Name = "Margherita",
                IsVeg=true,
                Crust="Wheat Thin",
                Price = 12,
                Pic="/images/Pic1.jpg"
            },
            new Pizza(){
                Id=102,
                Name = "Mexican Green Wave",
                IsVeg=true,
                Crust="Cheezee",
                Price = 24,
                Pic="/images/Pic2.jpg"
            }
        };
        // GET: PizzaController
        public ActionResult Index()
        {
            return View(pizzas);
        }

        // GET: PizzaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PizzaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PizzaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PizzaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PizzaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
