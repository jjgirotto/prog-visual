using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TUT08_JuliaMizuguchi_JulianaLeite.Models;

namespace TUT08_JuliaMizuguchi_JulianaLeite.Controllers
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
            List<Musica> lista = new List<Musica>();
            lista.Add(new Musica ("Quadro Verde", "Rubel", 422, "~/wwwroot/musicas/quadroverde.mp3"));
            lista.Add(new Musica ("Tenta Acreditar", "Anavitória", 234, "~/wwwroot/musicas/tentaacreditar.mp3"));
            lista.Add(new Musica ("Pensando Bem", "5 a Seco", 199, "~/wwwroot/musicas/pensandobem.mp3"));
            ViewData["Musicas"] = lista;
            ViewData["Texto1"] = "Bem Vindo ao MúsicaShopping";
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
