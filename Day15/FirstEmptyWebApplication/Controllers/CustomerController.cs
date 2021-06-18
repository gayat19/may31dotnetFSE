using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstEmptyWebApplication.Controllers
{
    public class CustomerController : Controller
    {
        public string Index()
        {
            return "Hello from customer controller";
        }
    }
}
