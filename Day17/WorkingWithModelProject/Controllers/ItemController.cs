using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkingWithModelProject.Models;

namespace WorkingWithModelProject.Controllers
{
    public class ItemController : Controller
    {
        static List<Item> items = new List<Item>();
        public IActionResult Index()
        {
            return View(items);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Item item)
        {
            items.Add(item);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            Item item;
            try
            {
                item = items.Single(itm => itm.Id == id);
            }
            catch(ArgumentNullException ane)
            {
                item = null;
            }
            catch(InvalidOperationException ioe)
            {
                item = null;
            }
            return View(item);
        }
        public IActionResult Delete(int id)
        {
            Item item;
            try
            {
                item = items.Single(itm => itm.Id == id);
            }
            catch (ArgumentNullException ane)
            {
                item = null;
            }
            catch (InvalidOperationException ioe)
            {
                item = null;
            }
            return View(item);
        }
        [HttpPost]
        public IActionResult Delete(int id,Item item)
        {
            items.Remove(item);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            Item item;
            try
            {
                item = items.Single(itm => itm.Id == id);
            }
            catch (ArgumentNullException ane)
            {
                item = null;
            }
            catch (InvalidOperationException ioe)
            {
                item = null;
            }
            return View(item);
        }
        [HttpPost]
        public IActionResult Edit(int id, Item item)
        {
            Item myItem = items.Single(itm => itm.Id == id);
            myItem.Name = item.Name;
            myItem.Price = item.Price;
            return RedirectToAction("Index");
        }
    }
}
