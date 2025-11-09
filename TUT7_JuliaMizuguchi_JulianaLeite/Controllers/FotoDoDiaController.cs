using Microsoft.AspNetCore.Mvc;
using TUT7_JuliaMizuguchi_JulianaLeite.Models;

namespace TUT7_JuliaMizuguchi_JulianaLeite.Controllers
{
    public class FotoDoDiaController : Controller
    {
        public IActionResult Index()
        {
            Foto f = new Foto { Codigo = "LONDRES 01", Titulo = "Big Ben" };
            return View(f);
        }
    }
}
