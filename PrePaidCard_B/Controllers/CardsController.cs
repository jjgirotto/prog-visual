using Microsoft.AspNetCore.Mvc;
using PrePaidCard_B.Data;
using PrePaidCard_B.Models;

namespace PrePaidCard_B.Controllers
{
    public class CardsController : Controller
    {
        private static List<PrePaidCard_BA> cards_B = SeedCards_B.Seed();
        public IActionResult Index()
        {
            return View(cards_B);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PrePaidCard_BA card)
        {
            cards_B.Add(card);
            return View("Index", cards_B);
        }

        [HttpPost]
        public IActionResult Index(string holderName)
        {
            if (holderName is null) return View("Index", cards_B);
            var cardsComNome_B = from i in cards_B where i.HolderName_B.Contains(holderName) select i;
            return View("Index", cardsComNome_B);
        }
        public IActionResult Edit(Guid id)
        {
            PrePaidCard_BA card_B = cards_B.FirstOrDefault(c => c.Id_B == id);
            if (card_B == null) return View("Index", cards_B);
            return View(card_B);
        }

        [HttpPost]
        public IActionResult Edit(Guid id, PrePaidCard_BA card_B)
        {
            PrePaidCard_BA c_B = cards_B.FirstOrDefault(c => c.Id_B == id);
            if (c_B == null) return View("Index", cards_B);
            c_B.Credit_B = card_B.Credit_B;
            return View("Index", cards_B);
        }

        public IActionResult Delete(Guid id)
        {
            PrePaidCard_BA c_B = cards_B.FirstOrDefault(c => c.Id_B == id);
            if (c_B == null) return View("Index", cards_B);
            return View(c_B);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            cards_B = cards_B.Where(c => c.Id_B != id).ToList();
            return View("Index", cards_B);
        }

        public IActionResult Details(Guid id)
        {
            PrePaidCard_BA c_B = cards_B.FirstOrDefault(c => c.Id_B == id);
            if (c_B == null) return View("Index", cards_B);
            return View(c_B);
        }


    }
}
