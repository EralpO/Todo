using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Web.Models;

namespace Todo.Web.CustomFilters
{
    public class FilterVariable : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
          var dictionary =  context.ActionArguments.Where(I => I.Key == "user").FirstOrDefault();
            var model =dictionary.Value as ClientViewModel;
            if (model.username.Length <= 6)
            {
                //context.Result = new RedirectResult("/Admin");
                //Error verilmesi gereken kısım 
            }
            base.OnActionExecuting(context);
        }
    }
}
