using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnserstandingMoreOnMVCProject.Models;

namespace UnserstandingMoreOnMVCProject.Controllers
{
    public class UserController : Controller
    {
        List<User> users = new List<User>() { 
            new User(){Username="abc",Password="123" },
            new User(){Username="xyz",Password="321" },
            new User(){Username="efg",Password="000" }
        };
        //[HttpGet]
        //public IActionResult Login()
        //{
        //    return View();
        //}
        ////[HttpPost]
        ////public IActionResult Login(IFormCollection collection)
        ////{
        ////    string username, password;
        ////    username = collection["username"].ToString();
        ////    password= collection["password"].ToString();
        ////    if (username == "abc" && password == "123")
        ////        ViewData["Message"] = "Welcome User";
        ////    else
        ////        ViewData["Message"] = "Invalid username or password";
        ////    return View();
        ////}
        //[HttpPost]
        //public IActionResult Login(string username,string password)
        //{
        //    //string username, password;
        //    //username = collection["username"].ToString();
        //    //password = collection["password"].ToString();
        //    if (username == "abc" && password == "123")
        //        ViewData["Message"] = "Welcome User";
        //    else
        //        ViewData["Message"] = "Invalid username or password";
        //    return View();
        //}
        //public string Index()
        //{
        //    return "Index in USer";
        //}
        //public string Another(int id)
        //{
        //    return "Another in USer with id "+id;
        //}

        [HttpGet]
        public IActionResult UserLoginCheck()
        {
            return View();
        }

        public IActionResult UserLoginCheck(User user)
        {
            ViewData["ErrorMessage"] = "";
            ViewData["Success"] = "";
            foreach (var item in users)
            {
                if (user.Username == item.Username && user.Password == item.Password)
                {
                    ViewData["Success"] = "Welcome user";
                    return View();
                }
            }
             ViewData["ErrorMessage"] = "Invalid username or password";
            return View();
        }
    }
}
