using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyPizzaStoreApplication.Models;
using MyPizzaStoreApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPizzaStoreApplication.Controllers
{
    public class PizzaController : Controller
    {
        private readonly ILogger<PizzaContext> _logger;
        private readonly IRepo<Pizza, int> _repo;

        public PizzaController(IRepo<Pizza,int> repo,ILogger<PizzaContext> logger)
        {
            _logger = logger;
            _repo = repo;
        }
        
        // GET: PizzaController
        public async Task<ActionResult> Index()
        {
            var pizzas = await _repo.GetAll();
            return View(pizzas);
        }

        // GET: PizzaController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            try
            {
                Pizza pizza = await _repo.Get(id);
                return View(pizza);
            }
            catch
            {
                _logger.LogError("Uable to get the edit");
            }
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
        public async Task<ActionResult> Create(Pizza pizza)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    int id = await _repo.Add(pizza);
                    if (id != -1)
                        return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
            return View();
        }

        // GET: PizzaController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {

            try
            {
                Pizza pizza = await _repo.Get(id);
                return View(pizza);
            }
            catch
            {
                _logger.LogError("Uable to get the edit");
            }
            return View();

        }

        // POST: PizzaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Pizza pizza)
        {
            try
            {
                Pizza myPizza = await _repo.Update(id, pizza);
                if (myPizza != null)
                    return RedirectToAction("Index");
            }
            catch
            {
                return View("Edit",pizza);
            }
            return View("Edit", pizza);
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
