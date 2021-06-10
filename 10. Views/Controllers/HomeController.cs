using _10._Views.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _10._Views.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {            
            return View();
        }
        public IActionResult Index1()
        {
            ViewData["Message"] = "Hello ASP.NET Core";
            return View();
        }
        public IActionResult Index2()
        {
            ViewBag.Message = "Hello ASP.NET Core";
            return View();
        }
        public IActionResult Index3()
        {
            ViewBag.Countries = new List<string> { "Бразилия", "Аргентина", "Уругвай", "Чили" };
            return View();
        }
        public IActionResult Index4()
        {
            List<string> countries = new List<string> { "Бразилия", "Аргентина", "Уругвай", "Чили" };
            return View(countries);
        }
        public IActionResult Index5()
        {
            return View();
        }
        public IActionResult Index6()
        {
            return View();
        }
        public ActionResult GetMessage()
        {
            return PartialView("_GetMessage");
        }
        public IActionResult Index7()
        {
            return View();
        }
        public IActionResult Index8()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
