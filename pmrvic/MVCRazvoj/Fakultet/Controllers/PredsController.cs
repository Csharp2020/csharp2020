using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fakultet.Models;
using System.Globalization;

namespace Fakultet.Controllers
{
    public class PredsController : Controller
    {
        private readonly FakultetContext _context;

        public PredsController(FakultetContext context)
        {
            _context = context;
        }

        // GET: Preds
        public async Task<IActionResult> Index()
        {
            var fakultetContext = _context.Pred.Include(p => p.SifOrgjedNavigation);
            return View(await fakultetContext.ToListAsync());
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
            if (broj_ocjena != 0)
            {
                decimal prosjecna_ocjena = Math.Truncate(ukupno * 1000 / (decimal)broj_ocjena) / 1000;

                return prosjecna_ocjena;
            }
            else
            {
                decimal prosjecna_ocjena = 0;
                return prosjecna_ocjena;
            }

        }
        // GET: Preds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //   ViewData["prosjecna_ocjena"] = prosjecnaOcjena(id);


            /**
             * 
             * */
            var ispit_detalji = from ispit in _context.Ispit
                       .Where(i => i.SifPred == id)
                          group ispit by ispit.SifPred into g
                          select new
                          {
                              // g.Key,
                              Prosjek = g.Average(ispit => ispit.Ocjena),
                              SumaOcjena = g.Sum(ispit => ispit.Ocjena),
                              MaxOcjena = g.Max(ispit => ispit.Ocjena)
                          };
                                           


            ViewData["prosjecna_ocjena"] = ispit_detalji.FirstOrDefault().Prosjek.ToString("F2", CultureInfo.InvariantCulture);
            ViewData["najveca_ocjena"] = ispit_detalji.FirstOrDefault().MaxOcjena.ToString("F2", CultureInfo.InvariantCulture);
            ViewData["zbroj_ocjena"] = ispit_detalji.FirstOrDefault().SumaOcjena.ToString("F2", CultureInfo.InvariantCulture);

            // uzmi samo ocjene iz ispita i stavi u listu, nakon toga izracunaj prosjek liste
            var TheQuery = (from a in _context.Ispit where a.SifPred == id select a.Ocjena).ToList().Average(a => a);
           // ViewData["prosjecna_ocjena"] = TheQuery.ToString("F2", CultureInfo.InvariantCulture);


            var pred = await _context.Pred
                .Include(p => p.SifOrgjedNavigation)
                .Include(p => p.PredNastavnik)      // dodano za many2many vezu
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
