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
    public class Doctors_JMJLController : Controller
    {
        private readonly HospitEST_JuliaMizuguchiJulianaLeiteContext _context;

        public Doctors_JMJLController(HospitEST_JuliaMizuguchiJulianaLeiteContext context)
        {
            _context = context;
        }

        // GET: Doctors_JMJL
        public async Task<IActionResult> Index()
        {
            var hospitEST_JuliaMizuguchiJulianaLeiteContext = _context.Doctor_JMJL.Include(d => d.Hospital_JMJL);
            return View(await hospitEST_JuliaMizuguchiJulianaLeiteContext.ToListAsync());
        }

        // GET: Doctors_JMJL/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor_JMJL = await _context.Doctor_JMJL
                .Include(d => d.Hospital_JMJL)
                .Include(d => d.Patients_JMJL)
                .FirstOrDefaultAsync(m => m.Id_JMJL == id);
            if (doctor_JMJL == null)
            {
                return NotFound();
            }

            return View(doctor_JMJL);
        }

        // GET: Doctors_JMJL/Create
        public IActionResult Create()
        {
            ViewData["Hospital_JMJLId"] = new SelectList(_context.Set<Hospital_JMJL>(), "Id_JMJL", "Id_JMJL");
            return View();
        }

        // POST: Doctors_JMJL/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_JMJL,Hospital_JMJLId,Name_JMJL,Practice_JMJL,PracticeYears_JMJL")] Doctor_JMJL doctor_JMJL)
        {
            if (ModelState.IsValid)
            {
                doctor_JMJL.Id_JMJL = Guid.NewGuid();
                _context.Add(doctor_JMJL);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Hospital_JMJLId"] = new SelectList(_context.Set<Hospital_JMJL>(), "Id_JMJL", "Id_JMJL", doctor_JMJL.Hospital_JMJLId);
            return View(doctor_JMJL);
        }

        // GET: Doctors_JMJL/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor_JMJL = await _context.Doctor_JMJL.FindAsync(id);
            if (doctor_JMJL == null)
            {
                return NotFound();
            }
            ViewData["Hospital_JMJLId"] = new SelectList(_context.Set<Hospital_JMJL>(), "Id_JMJL", "Id_JMJL", doctor_JMJL.Hospital_JMJLId);
            return View(doctor_JMJL);
        }

        // POST: Doctors_JMJL/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id_JMJL,Hospital_JMJLId,Name_JMJL,Practice_JMJL,PracticeYears_JMJL")] Doctor_JMJL doctor_JMJL)
        {
            if (id != doctor_JMJL.Id_JMJL)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doctor_JMJL);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Doctor_JMJLExists(doctor_JMJL.Id_JMJL))
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
            ViewData["Hospital_JMJLId"] = new SelectList(_context.Set<Hospital_JMJL>(), "Id_JMJL", "Id_JMJL", doctor_JMJL.Hospital_JMJLId);
            return View(doctor_JMJL);
        }

        // GET: Doctors_JMJL/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor_JMJL = await _context.Doctor_JMJL
                .Include(d => d.Hospital_JMJL)
                .FirstOrDefaultAsync(m => m.Id_JMJL == id);
            if (doctor_JMJL == null)
            {
                return NotFound();
            }

            return View(doctor_JMJL);
        }

        // POST: Doctors_JMJL/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var doctor_JMJL = await _context.Doctor_JMJL.FindAsync(id);
            if (doctor_JMJL != null)
            {
                _context.Doctor_JMJL.Remove(doctor_JMJL);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Doctor_JMJLExists(Guid id)
        {
            return _context.Doctor_JMJL.Any(e => e.Id_JMJL == id);
        }
    }
}
