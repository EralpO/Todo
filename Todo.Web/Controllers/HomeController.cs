using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Todo.Web.Models;

namespace Todo.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            TempData["isim"] = "eralp";
            return View(new List<ClientViewModel>() { 
            new ClientViewModel(){name="eralp"},
            new ClientViewModel(){name="ahmet"},
            new ClientViewModel(){name="mehmet"}



            });
        }
    }
}
