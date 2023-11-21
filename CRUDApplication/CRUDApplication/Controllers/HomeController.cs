using Microsoft.AspNetCore.Mvc;
using CRUDApplication.Models;
using System.Diagnostics;

namespace CRUDApplication.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Product()
        {
            return View("~/Views/Product/Index.cshtml");
        }

        public IActionResult Category()
        {
            return View("~/Views/Category/Index.cshtml");
        }
        public IActionResult Factory()
        {
            return View("~/Views/Factory/Index.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}