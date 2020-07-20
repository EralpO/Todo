using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Web.Models;

namespace Todo.Web.ViewComponents
{
    public class Products : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("ProductViewComponent",new List<ClientViewModel>() {
            new ClientViewModel(){username="eralp"},
            new ClientViewModel(){username="ahmet"},
            new ClientViewModel(){username="mehmet"} });
        }
    }
}
