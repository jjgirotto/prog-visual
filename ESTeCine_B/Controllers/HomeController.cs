using System.Diagnostics;
using ESTeCine_B.Models;
using Microsoft.AspNetCore.Mvc;

namespace ESTeCine_B.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private List<Filme> filmes;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            filmes = new List<Filme> {
                new Filme
                {
                    Titulo = "Pulp Fiction",
                    Realizador = "Quentin Tarantino",
                    Atores = new List<string>{"John Travolta", "Uma Thurman", "Samuel L. Jackson" },
                    Duracao = 154,
                    Ano = 1994,
                    Estreia = true
                },
                new Filme
                {
                    Titulo = "Blade Runner",
                    Realizador = "Ridley Scott",
                    Atores = new List<string>{"Harrison Ford", "David Webb Peoples", "Philip K. Dick" },
                    Duracao = 117,
                    Ano = 1982,
                    Estreia = false
                },
                new Filme
                {
                    Titulo = "Stalker",
                    Realizador = "Andrei Tarkovsy",
                    Atores = new List<string>{"Alisa Freyndlikh", "Aleksandr Kaydanovskiy", "Anatoliy Solonitsyn" },
                    Duracao = 162,
                    Ano = 1979,
                    Estreia = true
                },
                new Filme
                {
                    Titulo = "Dersu Uzala",
                    Realizador = "Akira Kurosawa",
                    Atores = new List<string>{"Yuriy Solomin", "Maksim Munzuk", "Mikhail Bychkov" },
                    Duracao = 142,
                    Ano = 1975,
                    Estreia = true
                },

                new Filme
                {
                    Titulo = "Ran",
                    Realizador = "Akira Kurosawa",
                    Atores = new List<string>{"Tatsuya Nakadai", "Akira Terao", "Jinpachi Nezu" },
                    Duracao = 160,
                    Ano = 1985,
                    Estreia = true
                }

            };
        }

        public IActionResult Index()
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

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult FilmeDoDia()
        {
            Filme filmeDoDia = filmes[0];
            ViewData["IndexFilme"] = $"Filme 1 de {filmes.Count}";
            return View(filmeDoDia);
        }

        public VirtualFileResult DescarregarBilhete(string ficheiro)
        {
            return File($"~/documents/{ficheiro}.pdf", "application/pdf", $"{ficheiro}.pdf");
        }

    }
}
