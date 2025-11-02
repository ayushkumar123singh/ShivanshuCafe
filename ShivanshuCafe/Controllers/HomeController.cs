using Microsoft.AspNetCore.Mvc;
using ShivanshuCafe.Models;
using System.Diagnostics;

namespace ShivanshuCafe.Controllers
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

        [Route("jobs")]
        public IActionResult Jobs()
        {
            return View();
        }

        [Route("services")]
        public IActionResult Services()
        {
            return View();
        }

        [Route("contactUs")]
        public IActionResult Contact()
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
