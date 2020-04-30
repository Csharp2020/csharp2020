using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EntityFramework.Models;

namespace EntityFramework.Controllers
{
    public class PredsController : Controller
    {
        private readonly fakultetContext _context;

        public PredsController(fakultetContext context)
        {
            _context = context;
        }

        public decimal prosjecnaOcjena(int? id)
        {
            var ispit = _context.Ispit;
            int broj_ocjena = 0;
            int ukupno = 0;
            foreach (var item in ispit)
            {
                if (item.SifPred == id)
                {
                    ukupno += item.Ocjena;
                    broj_ocjena++;
                }
            }
            if (broj_ocjena != 0) {
                decimal prosjecna_ocjena = Math.Truncate(ukupno*1000 / (decimal)broj_ocjena)/1000;

                return prosjecna_ocjena;
            }
            else { 
                decimal prosjecna_ocjena = 0;
                return prosjecna_ocjena;
            }

        }

        // GET: Preds
        public async Task<IActionResult> Index()
        {
            var fakultetContext = _context.Pred.Include(p => p.SifOrgjedNavigation);
            return View(await fakultetContext.ToListAsync());
        }

        // GET: Preds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewData["prosjecna_ocjena"] = prosjecnaOcjena(id);

            var pred = await _context.Pred
                .Include(p => p.SifOrgjedNavigation)
                .Include(p => p.PredNastavnik)
                    .ThenInclude(p => p.Nastavnik)
                .FirstOrDefaultAsync(m => m.SifPred == id);
            if (pred == null)
            {
                return NotFound();
            }

            return View(pred);
        }

        // GET: Preds/Create
        public IActionResult Create()
        {
            ViewData["SifOrgjed"] = new SelectList(_context.Orgjed, "SifOrgjed", "NazOrgjed");
            return View();
        }

        // POST: Preds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SifPred,KratPred,NazPred,SifOrgjed,UpisanoStud,BrojSatiTjedno")] Pred pred)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pred);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SifOrgjed"] = new SelectList(_context.Orgjed, "SifOrgjed", "NazOrgjed", pred.SifOrgjed);
            return View(pred);
        }

        // GET: Preds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pred = await _context.Pred.FindAsync(id);
            if (pred == null)
            {
                return NotFound();
            }
            ViewData["SifOrgjed"] = new SelectList(_context.Orgjed, "SifOrgjed", "NazOrgjed", pred.SifOrgjed);
            return View(pred);
        }

        // POST: Preds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SifPred,KratPred,NazPred,SifOrgjed,UpisanoStud,BrojSatiTjedno")] Pred pred)
        {
            if (id != pred.SifPred)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pred);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PredExists(pred.SifPred))
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
            ViewData["SifOrgjed"] = new SelectList(_context.Orgjed, "SifOrgjed", "NazOrgjed", pred.SifOrgjed);
            return View(pred);
        }

        // GET: Preds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pred = await _context.Pred
                .Include(p => p.SifOrgjedNavigation)
                .FirstOrDefaultAsync(m => m.SifPred == id);
            if (pred == null)
            {
                return NotFound();
            }

            return View(pred);
        }

        // POST: Preds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pred = await _context.Pred.FindAsync(id);
            _context.Pred.Remove(pred);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PredExists(int id)
        {
            return _context.Pred.Any(e => e.SifPred == id);
        }
    }
}
