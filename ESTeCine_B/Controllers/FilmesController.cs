using ESTeCine_B.Models;
using Microsoft.AspNetCore.Mvc;

namespace ESTeCine_B.Controllers
{
    public class FilmesController : Controller
    {
        private static List<Filme> filmes = new List<Filme>();
        public FilmesController()
        {
            if (filmes.Count == 0)
            {
                filmes.AddRange(new List<Filme> {
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
                });
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cartaz()
        {
            return View(filmes);
        }

        public IActionResult Estreia()
        {
            var filmesEstreia = filmes.Where(f => f.Estreia).ToList();
            if (filmesEstreia.Count == 0)
            {
                return View("Não existem filmes em estreia");
            }
            return View(filmesEstreia);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Filme filme)
        {
            filmes.Add(filme);
            return View("Cartaz", filmes);
        }

        //edit
        public IActionResult Edit(String titulo)
        {
            var filme = filmes.FirstOrDefault(f => f.Titulo == titulo);
            if (filme == null) return View("Cartaz", filmes);
            return View(filme);
        }

        [HttpPost]
        public IActionResult Edit(String titulo, Filme filme)
        {
            var f = filmes.FirstOrDefault(f => f.Titulo == titulo);
            if (f == null) return View("Cartaz", filmes);
            f.Titulo = filme.Titulo;
            f.Realizador = filme.Realizador;
            f.Duracao = filme.Duracao;
            f.Ano = filme.Ano;
            return View("Cartaz", filmes);
        }

        //delete
        public IActionResult Delete(String titulo)
        {
            var filme = filmes.FirstOrDefault(f => f.Titulo == titulo);
            if (filme == null) return View("Cartaz", filmes);
            return View(filme);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(String titulo)
        {
            filmes = filmes.Where(f => f.Titulo != titulo).ToList();
            return View("Cartaz", filmes);
        }

    }
}
