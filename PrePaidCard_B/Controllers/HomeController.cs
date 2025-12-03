using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrePaidCard_B.Models;

namespace PrePaidCard_B.Controllers
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
            PrePaidCard_BA prePaidCard_B = new PrePaidCard_BA("João Silva", 100m);
            return View(prePaidCard_B);
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
