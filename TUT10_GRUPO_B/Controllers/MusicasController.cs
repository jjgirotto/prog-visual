using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TUT10_GRUPO_B.Data;
using TUT10_GRUPO_B.Models;

namespace TUT10_GRUPO_B.Controllers
{
    public class MusicasController : Controller
    {
        private readonly MusicasDbContext _context;

        public MusicasController(MusicasDbContext context)
        {
            _context = context;
        }

        // GET: Musicas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Fotos.ToListAsync());
        }

        // GET: Musicas/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musica_B = await _context.Fotos
                .FirstOrDefaultAsync(m => m.Musica_BId == id);
            if (musica_B == null)
            {
                return NotFound();
            }

            return View(musica_B);
        }

        // GET: Musicas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Musicas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Musica_BId,Titulo_B,Autor_B,Duracao_B,Ficheiro_B")] Musica_B musica_B)
        {
            if (ModelState.IsValid)
            {
                musica_B.Ficheiro_B = "/musicas/" + musica_B.Titulo_B.ToLower() + ".mp3";
                musica_B.Musica_BId = Guid.NewGuid();
                _context.Add(musica_B);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(musica_B);
        }

        // GET: Musicas/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musica_B = await _context.Fotos.FindAsync(id);
            if (musica_B == null)
            {
                return NotFound();
            }
            return View(musica_B);
        }

        // POST: Musicas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Musica_BId,Titulo_B,Autor_B,Duracao_B,Ficheiro_B")] Musica_B musica_B)
        {
            if (id != musica_B.Musica_BId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(musica_B);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Musica_BExists(musica_B.Musica_BId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(musica_B);
        }

        // GET: Musicas/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musica_B = await _context.Fotos
                .FirstOrDefaultAsync(m => m.Musica_BId == id);
            if (musica_B == null)
            {
                return NotFound();
            }

            return View(musica_B);
        }

        // POST: Musicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var musica_B = await _context.Fotos.FindAsync(id);
            if (musica_B != null)
            {
                _context.Fotos.Remove(musica_B);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Musica_BExists(Guid id)
        {
            return _context.Fotos.Any(e => e.Musica_BId == id);
        }
    }
}
