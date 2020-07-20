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
            new ClientViewModel(){name="eralp"},
            new ClientViewModel(){name="ahmet"},
            new ClientViewModel(){name="mehmet"} });
        }
    }
}
