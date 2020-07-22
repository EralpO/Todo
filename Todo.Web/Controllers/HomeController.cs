using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Todo.Web.CustomFilters;
using Todo.Web.Models;

namespace Todo.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            TempData["isim"] = "eralp";
            SetCookie();
            ViewBag.cookie = GetCookie();
            return View();
        }

        
        public IActionResult Register()
        {
            return View();
        }
        [FilterVariable]
        [HttpPost]
        public IActionResult Register2(ClientViewModel user)
        {
            
            return View();
        }
        public void SetCookie()
        {
            HttpContext.Response.Cookies.Append("name", "eralp", new Microsoft.AspNetCore.Http.CookieOptions()
            {
                Expires = DateTime.Now.AddDays(1),
                HttpOnly = true,

            });
        }
        public string GetCookie()
        {
            return HttpContext.Request.Cookies["name"];
        }
        public IActionResult PageError(int code)
        {
            ViewBag.status = code;
            if (code == 404)
                ViewBag.Code = "Sayfa Bulunamadı";
            else if (code == 500)
                ViewBag.Code = "Server Hatası";

            return View();
        }
        public IActionResult Error()
        {
            var ExceptionHandler = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            CustomLogger.NLogLogger nLogLogger = new CustomLogger.NLogLogger();
            nLogLogger.LogWithNLog($"Hatanın oluştuğu yer:{ExceptionHandler.Path} \n Hata mesajı : {ExceptionHandler.Error.Message} \n Stack Trace: {ExceptionHandler.Error.StackTrace}");

            ViewBag.Path = ExceptionHandler.Path;
            ViewBag.Message = ExceptionHandler.Error.Message;
            return View();
        }
        public IActionResult Hata()
        {
            throw new Exception("Hata oluştu.");
        }
    }
}
