using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UnderstandingDataTransferInMVCProject.Models;

namespace UnderstandingDataTransferInMVCProject.Controllers
{
    public class UserController : Controller
    {
        private CompanyContext _context;

        public UserController(CompanyContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            User user = new User();
            user.Username = Convert.ToInt32(TempData["EmployeeId"]);
            return View(user);
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            var emp = _context.Employees.SingleOrDefault(e => e.Id == user.Username );

            if (emp != null)
            {
                using var hmac = new HMACSHA512(emp.PasswordSalt);
                var checkPass = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password));
                for (int i = 0; i < checkPass.Length; i++)
                {
                    if (checkPass[i] != emp.Password[i])
                    {
                        ViewBag.Message = "Invalid username or password";
                        return View();
                    }
                }
                ViewBag.Message = "welcome "+emp.Name;
                TempData["EmployeeName"] = emp.Name;
                return RedirectToAction("Index", "Home");
            }
            else
                ViewBag.Message = "Invalid username or password";
            return View();
        }
        public IActionResult Register()
        {
            //ViewBag.RetypePassword = "Retype Password";
            //var departmentList = _context.Departments
            //    .Select(sl => new SelectListItem() {Text=sl.Name,Value=sl.Id.ToString()}).ToList();
            //departmentList.Insert(0, new SelectListItem { Value = string.Empty, Text = "---Select Department---" });
            //ViewBag.DepartmentList = departmentList;

            var departmentList = _context.Departments
                .Select(sl => new SelectListItem() { Text = sl.Name, Value = sl.Id.ToString() }).ToList();
            departmentList.Insert(0, new SelectListItem { Value = string.Empty, Text = "---Select Department---" });
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            employeeViewModel.DeparmentList = departmentList;
            return View(employeeViewModel);
        }
        [HttpPost]
        public IActionResult Register(EmployeeViewModel employee)
        {
            if(ModelState.IsValid)
            {
                Employee myEmployee = employee;
                using var hmac = new HMACSHA512();
                myEmployee.Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(employee.UserPassword));
                myEmployee.PasswordSalt = hmac.Key;
                _context.Employees.Add(myEmployee);
                _context.SaveChanges();
                TempData["EmployeeId"] = myEmployee.Id;
                return RedirectToAction("Login");
            }
            var departmentList = _context.Departments
                 .Select(sl => new SelectListItem() { Text = sl.Name, Value = sl.Id.ToString() }).ToList();
            departmentList.Insert(0, new SelectListItem { Value = string.Empty, Text = "---Select Department---" });
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            employeeViewModel.DeparmentList = departmentList;
            return View(employeeViewModel);
        }
    }
}
