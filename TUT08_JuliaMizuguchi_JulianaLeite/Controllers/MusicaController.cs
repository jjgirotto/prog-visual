using Microsoft.AspNetCore.Mvc;
using TUT08_JuliaMizuguchi_JulianaLeite.Models;

namespace TUT08_JuliaMizuguchi_JulianaLeite.Controllers
{
    public class MusicaController : Controller
    {
        public IActionResult Index()
        {
            List<Musica> listaDeMusicas = new List<Musica>();
            Musica m1 = new Musica ("Quadro Verde", "Rubel", 422, "~/wwwroot/musicas/quadroverde");
            Musica m2 = new Musica ("Tenta Acreditar", "Anavitória", 234, "~/wwwroot/musicas/tentaacreditar");
            Musica m3 = new Musica ("Pensando Bem", "5 a Seco", 199, "~/wwwroot/musicas/pensandobem");
            listaDeMusicas.Add(m1);
            listaDeMusicas.Add(m2);
            listaDeMusicas.Add(m3);
            return View(listaDeMusicas);
        }

        public IActionResult ExibirMusica(string titulo)
        {
            List<Musica> listaDeMusicas = new List<Musica>();
            listaDeMusicas.Add(new Musica("Quadro Verde", "Rubel", 422, "~/musicas/quadroverde.mp3"));
            listaDeMusicas.Add(new Musica("Tenta Acreditar", "Anavitória", 234, "~/musicas/tentaacreditar.mp3"));
            listaDeMusicas.Add(new Musica("Pensando Bem", "5 a Seco", 199, "~/musicas/pensandobem.mp3"));

            Musica musicaEncontrada = listaDeMusicas.Find(m => m.Titulo == titulo);
            ViewBag.MusicaParaExibir = musicaEncontrada;
            return View();
        }
    }
}
