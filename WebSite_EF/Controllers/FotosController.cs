using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebSite_EF.Data;
using WebSite_EF.Models;

namespace WebSite_EF.Controllers
{
    public class FotosController : Controller
    {
        private readonly FotosDbContext _context;

        public FotosController(FotosDbContext context)
        {
            _context = context;
        }

        // GET: Fotos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Fotos.ToListAsync());
        }

        // GET: Fotos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foto = await _context.Fotos
                .FirstOrDefaultAsync(m => m.FotoId == id);
            if (foto == null)
            {
                return NotFound();
            }

            return View(foto);
        }

        // GET: Fotos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Fotos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FotoId,Codigo,Titulo,Autor,Preco")] Foto foto)
        {
            if (ModelState.IsValid)
            {
                foto.FotoId = Guid.NewGuid();
                _context.Add(foto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(foto);
        }

        // GET: Fotos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foto = await _context.Fotos.FindAsync(id);
            if (foto == null)
            {
                return NotFound();
            }
            return View(foto);
        }

        // POST: Fotos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("FotoId,Codigo,Titulo,Autor,Preco")] Foto foto)
        {
            if (id != foto.FotoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(foto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FotoExists(foto.FotoId))
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
            return View(foto);
        }

        // GET: Fotos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foto = await _context.Fotos
                .FirstOrDefaultAsync(m => m.FotoId == id);
            if (foto == null)
            {
                return NotFound();
            }

            return View(foto);
        }

        // POST: Fotos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var foto = await _context.Fotos.FindAsync(id);
            if (foto != null)
            {
                _context.Fotos.Remove(foto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FotoExists(Guid id)
        {
            return _context.Fotos.Any(e => e.FotoId == id);
        }
    }
}
