using BulkyBookWeb.Models;

using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

namespace BulkyBookWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Help()
        {
            return View("HelpView");
        }

        public IActionResult Index()
        {
            //_logger.LogInformation("Demarrage de l'application");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}