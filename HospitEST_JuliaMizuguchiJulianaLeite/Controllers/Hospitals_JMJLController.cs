using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HospitEST_JuliaMizuguchiJulianaLeite.Data;
using HospitEST_JuliaMizuguchiJulianaLeite.Models;

namespace HospitEST_JuliaMizuguchiJulianaLeite.Controllers
{
    public class Hospitals_JMJLController : Controller
    {
        private readonly HospitEST_JuliaMizuguchiJulianaLeiteContext _context;

        public Hospitals_JMJLController(HospitEST_JuliaMizuguchiJulianaLeiteContext context)
        {
            _context = context;
        }

        // GET: Hospitals_JMJL
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hospital_JMJL.ToListAsync());
        }

        // GET: Hospitals_JMJL/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospital_JMJL = await _context.Hospital_JMJL
                .Include(h => h.Doctors_JMJL)
                .FirstOrDefaultAsync(m => m.Id_JMJL == id);
            if (hospital_JMJL == null)
            {
                return NotFound();
            }

            return View(hospital_JMJL);
        }

        // GET: Hospitals_JMJL/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hospitals_JMJL/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_JMJL,Name_JMJL,Location_JMJL")] Hospital_JMJL hospital_JMJL)
        {
            if (ModelState.IsValid)
            {
                hospital_JMJL.Id_JMJL = Guid.NewGuid();
                _context.Add(hospital_JMJL);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hospital_JMJL);
        }

        // GET: Hospitals_JMJL/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospital_JMJL = await _context.Hospital_JMJL.FindAsync(id);
            if (hospital_JMJL == null)
            {
                return NotFound();
            }
            return View(hospital_JMJL);
        }

        // POST: Hospitals_JMJL/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id_JMJL,Name_JMJL,Location_JMJL")] Hospital_JMJL hospital_JMJL)
        {
            if (id != hospital_JMJL.Id_JMJL)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hospital_JMJL);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Hospital_JMJLExists(hospital_JMJL.Id_JMJL))
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
            return View(hospital_JMJL);
        }

        // GET: Hospitals_JMJL/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospital_JMJL = await _context.Hospital_JMJL
                .FirstOrDefaultAsync(m => m.Id_JMJL == id);
            if (hospital_JMJL == null)
            {
                return NotFound();
            }

            return View(hospital_JMJL);
        }

        // POST: Hospitals_JMJL/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var hospital_JMJL = await _context.Hospital_JMJL.FindAsync(id);
            if (hospital_JMJL != null)
            {
                _context.Hospital_JMJL.Remove(hospital_JMJL);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Hospital_JMJLExists(Guid id)
        {
            return _context.Hospital_JMJL.Any(e => e.Id_JMJL == id);
        }
    }
}
