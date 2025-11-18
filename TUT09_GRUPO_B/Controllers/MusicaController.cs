using Microsoft.AspNetCore.Mvc;
using TUT09_GRUPO_B.Models;

namespace TUT09_GRUPO_B.Controllers
{
    public class MusicaController : Controller
    {
        private static List<Musica_B> musicas = new List<Musica_B>();
        public IActionResult Index()
        {
            if (!musicas.Any())
            {
                musicas.Add(new Musica_B("Pensando Bem", "5 a Seco", 199));
                musicas.Add(new Musica_B("Quadro Verde", "Rubel", 422));
                musicas.Add(new Musica_B("Tenta Acreditar", "Anavitória", 234));
            }
            return View(musicas);
        }

        //Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Musica_B musica)
        {
            musica.AtualizarPath();
            musicas.Add(musica);
            return View("Index", musicas);
        }

        //Details
        public IActionResult Details(Guid id)
        {
            var musica = musicas.FirstOrDefault(m => m.Id_B == id);
            if (musica == null) return View("Index", musicas);
            return View(musica);
        }

        //edit
        public IActionResult Edit(Guid id)
        {
            var musica = musicas.FirstOrDefault(m => m.Id_B == id);
            if (musica == null) return View("Index", musicas);
            return View(musica);
        }

        [HttpPost]
        public IActionResult Edit(Guid id, Musica_B musica)
        {
            var m = musicas.FirstOrDefault(m => m.Id_B == id);
            if (m == null) return View("Index", musicas);
            m.Titulo_B = musica.Titulo_B;
            m.Autor_B = musica.Autor_B;
            m.Duracao_B = musica.Duracao_B;
            m.AtualizarPath();
            return View("Index", musicas);
        }

        //delete
        public IActionResult Delete(Guid id)
        {
            var musica = musicas.FirstOrDefault(m => m.Id_B == id);
            if (musica == null) return View("Index");
            return View(musica);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            musicas = musicas.Where(m => m.Id_B != id).ToList();
            return View("Index", musicas);
        }

        //search by title
        [HttpPost]
        public IActionResult Index(string titulo)
        {
            if (string.IsNullOrEmpty(titulo))
            {
                return View(musicas);
            }
            var filteredMusicas = musicas.Where(m => m.Titulo_B.ToLower().Contains(
                titulo.ToLower(), StringComparison.InvariantCulture)).ToList();
            return View(filteredMusicas);
        }

    }
}
