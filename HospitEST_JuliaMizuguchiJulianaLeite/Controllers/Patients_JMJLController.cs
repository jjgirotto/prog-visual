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
    public class Patients_JMJLController : Controller
    {
        private readonly HospitEST_JuliaMizuguchiJulianaLeiteContext _context;

        public Patients_JMJLController(HospitEST_JuliaMizuguchiJulianaLeiteContext context)
        {
            _context = context;
        }

        // GET: Patient_JMJL
        public async Task<IActionResult> Index()
        {
            var hospitEST_JuliaMizuguchiJulianaLeiteContext = _context.Patient_JMJL.Include(p => p.Doctor_JMJL);
            return View(await hospitEST_JuliaMizuguchiJulianaLeiteContext.ToListAsync());
        }

        // GET: Patient_JMJL/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient_JMJL = await _context.Patient_JMJL
                .Include(p => p.Doctor_JMJL)
                .FirstOrDefaultAsync(m => m.Id_JMJL == id);
            if (patient_JMJL == null)
            {
                return NotFound();
            }

            return View(patient_JMJL);
        }

        // GET: Patient_JMJL/Create
        public IActionResult Create()
        {
            ViewData["Doctor_JMJLId"] = new SelectList(_context.Set<Doctor_JMJL>(), "Id_JMJL", "Id_JMJL");
            return View();
        }

        // POST: Patient_JMJL/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_JMJL,Doctor_JMJLId,Name_JMJL,DateOfBirth_JMJL,Pathology_JMJL")] Patient_JMJL patient_JMJL)
        {
            if (ModelState.IsValid)
            {
                patient_JMJL.Id_JMJL = Guid.NewGuid();
                _context.Add(patient_JMJL);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Doctor_JMJLId"] = new SelectList(_context.Set<Doctor_JMJL>(), "Id_JMJL", "Id_JMJL", patient_JMJL.Doctor_JMJLId);
            return View(patient_JMJL);
        }

        // GET: Patient_JMJL/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient_JMJL = await _context.Patient_JMJL.FindAsync(id);
            if (patient_JMJL == null)
            {
                return NotFound();
            }
            ViewData["Doctor_JMJLId"] = new SelectList(_context.Set<Doctor_JMJL>(), "Id_JMJL", "Id_JMJL", patient_JMJL.Doctor_JMJLId);
            return View(patient_JMJL);
        }

        // POST: Patient_JMJL/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id_JMJL,Doctor_JMJLId,Name_JMJL,DateOfBirth_JMJL,Pathology_JMJL")] Patient_JMJL patient_JMJL)
        {
            if (id != patient_JMJL.Id_JMJL)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patient_JMJL);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Patient_JMJLExists(patient_JMJL.Id_JMJL))
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
            ViewData["Doctor_JMJLId"] = new SelectList(_context.Set<Doctor_JMJL>(), "Id_JMJL", "Id_JMJL", patient_JMJL.Doctor_JMJLId);
            return View(patient_JMJL);
        }

        // GET: Patient_JMJL/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient_JMJL = await _context.Patient_JMJL
                .Include(p => p.Doctor_JMJL)
                .FirstOrDefaultAsync(m => m.Id_JMJL == id);
            if (patient_JMJL == null)
            {
                return NotFound();
            }

            return View(patient_JMJL);
        }

        // POST: Patient_JMJL/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var patient_JMJL = await _context.Patient_JMJL.FindAsync(id);
            if (patient_JMJL != null)
            {
                _context.Patient_JMJL.Remove(patient_JMJL);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Patient_JMJLExists(Guid id)
        {
            return _context.Patient_JMJL.Any(e => e.Id_JMJL == id);
        }
    }
}
