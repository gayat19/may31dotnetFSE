using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnderstandingService.Models;
using UnderstandingService.Services;

namespace UnderstandingService.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepo<Product, int> _repo;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IRepo<Product,int> repo,ILogger<ProductController> logger)
        {
            _repo = repo;
            _logger = logger;
        }
        public IActionResult Index()
        {
            var products = _repo.GetAll();
            if(products == null)
            {
                ViewBag.Message = "No products available";
                return RedirectToAction("Create");
            }
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            try
            {
               if(ModelState.IsValid)
                {
                    if (_repo.Add(product))
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            catch (Exception)
            {
                _logger.LogDebug("Create product failed " + product);
            }
            return View();
        }
    }
}
