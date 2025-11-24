using GB_Discoteca_JMJL.Models;
using Microsoft.AspNetCore.Mvc;

namespace GB_Discoteca_JMJL.Controllers
{
    public class Musica_JMJLController : Controller
    {
        
        private static List<Musica_JMJL> musicas_JMJL = new List<Musica_JMJL>();

        public List<Musica_JMJL> Musicas_JMJL
        {
            get { return musicas_JMJL; }
            set { musicas_JMJL = value; }
        }

        public IActionResult Index()
        {
            Musica_JMJL musica_JMJL = new Musica_JMJL(1, "The Jazz Piano", new DateTime(2013, 10, 31));
            musica_JMJL.Executantes_JMJL.Add("Bensound");
            musica_JMJL.Executantes_JMJL.Add("Bensound Jr.");
            musica_JMJL.Executantes_JMJL.Add("Granny Bensound");
            ViewBag.CaminhoMusica = "/sounds/bensound-thejazzpiano.mp3";
            return View(musica_JMJL);
        }

        public VirtualFileResult Descarregar_JMJL()
        {
            return File("~/sounds/bensound-thejazzpiano.mp3", "application/mp3", "bensound-thejazzpiano.mp3");
        }

        public IActionResult ListarMusicas_JMJL ()
        {
            Musica_JMJL musica1_JMJL = new Musica_JMJL(2, "Jazz Comedy", new DateTime(2014, 11, 12));
            musica1_JMJL.Executantes_JMJL.Add("Bensound");
            musica1_JMJL.Executantes_JMJL.Add("Bensound Jr.");
            musica1_JMJL.Executantes_JMJL.Add("Granny Bensound");
            Musica_JMJL musica2_JMJL = new Musica_JMJL(3, "Jazz Frenchy", new DateTime(2015, 11, 20));
            musica2_JMJL.Executantes_JMJL.Add("Bensound");
            musica2_JMJL.Executantes_JMJL.Add("Bensound Jr.");
            musica2_JMJL.Executantes_JMJL.Add("Granny Bensound");
            musicas_JMJL.Add(musica1_JMJL);
            musicas_JMJL.Add(musica2_JMJL);
            return View(musicas_JMJL);
        }
    }
}
