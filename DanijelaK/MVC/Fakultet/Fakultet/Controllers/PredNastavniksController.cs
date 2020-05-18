using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fakultet.Models;

namespace Fakultet.Controllers
{
    public class PredNastavniksController : Controller
    {
        private readonly FakultetContext _context;

        public PredNastavniksController(FakultetContext context)
        {
            _context = context;
        }

        // GET: PredNastavniks
        public async Task<IActionResult> Index()
        {
            var fakultetContext = _context.PredNastavnik.Include(p => p.Nastavnik).Include(p => p.Predmet);
            return View(await fakultetContext.ToListAsync());
        }

        // GET: PredNastavniks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var predNastavnik = await _context.PredNastavnik
                .Include(p => p.Nastavnik)
                .Include(p => p.Predmet)
                .FirstOrDefaultAsync(m => m.SifNastavnik == id);
            if (predNastavnik == null)
            {
                return NotFound();
            }

            return View(predNastavnik);
        }

        // GET: PredNastavniks/Create
        public IActionResult Create()
        {
            ViewData["SifNastavnik"] = new SelectList(_context.Nastavnik, "SifNastavnik", "ImeNastavnik");
            ViewData["SifPred"] = new SelectList(_context.Pred, "SifPred", "NazPred");
            return View();
        }

        // POST: PredNastavniks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SifNastavnik,SifPred")] PredNastavnik predNastavnik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(predNastavnik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SifNastavnik"] = new SelectList(_context.Nastavnik, "SifNastavnik", "ImeNastavnik", predNastavnik.SifNastavnik);
            ViewData["SifPred"] = new SelectList(_context.Pred, "SifPred", "NazPred", predNastavnik.SifPred);
            return View(predNastavnik);
        }

        // GET: PredNastavniks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var predNastavnik = await _context.PredNastavnik.FindAsync(id);
            if (predNastavnik == null)
            {
                return NotFound();
            }
            ViewData["SifNastavnik"] = new SelectList(_context.Nastavnik, "SifNastavnik", "ImeNastavnik", predNastavnik.SifNastavnik);
            ViewData["SifPred"] = new SelectList(_context.Pred, "SifPred", "NazPred", predNastavnik.SifPred);
            return View(predNastavnik);
        }

        // POST: PredNastavniks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SifNastavnik,SifPred")] PredNastavnik predNastavnik)
        {
            if (id != predNastavnik.SifNastavnik)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(predNastavnik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PredNastavnikExists(predNastavnik.SifNastavnik))
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
            ViewData["SifNastavnik"] = new SelectList(_context.Nastavnik, "SifNastavnik", "ImeNastavnik", predNastavnik.SifNastavnik);
            ViewData["SifPred"] = new SelectList(_context.Pred, "SifPred", "NazPred", predNastavnik.SifPred);
            return View(predNastavnik);
        }

        // GET: PredNastavniks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var predNastavnik = await _context.PredNastavnik
                .Include(p => p.Nastavnik)
                .Include(p => p.Predmet)
                .FirstOrDefaultAsync(m => m.SifNastavnik == id);
            if (predNastavnik == null)
            {
                return NotFound();
            }

            return View(predNastavnik);
        }

        // POST: PredNastavniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var predNastavnik = await _context.PredNastavnik.FindAsync(id);
            _context.PredNastavnik.Remove(predNastavnik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PredNastavnikExists(int id)
        {
            return _context.PredNastavnik.Any(e => e.SifNastavnik == id);
        }
    }
}
