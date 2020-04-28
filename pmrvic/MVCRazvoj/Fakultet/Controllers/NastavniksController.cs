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
    public class NastavniksController : Controller
    {
        private readonly FakultetContext _context;

        public NastavniksController(FakultetContext context)
        {
            _context = context;
        }

        // GET: Nastavniks
        public async Task<IActionResult> Index(int? pageNumber)
        {
            var fakultetContext = _context.Nastavnik.Include(n => n.PbrStanNavigation).Include(n => n.SifOrgjedNavigation);

            int pageSize = 6;  // broj rekorda koje zelimo prikazati
            return View(await Lib.PaginatedList<Nastavnik>.CreateAsync(fakultetContext.AsNoTracking(), pageNumber ?? 1, pageSize));
            return View(await fakultetContext.ToListAsync());
        }

        // GET: Nastavniks/Details/122
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nastavnik = await _context.Nastavnik
                .Include(n => n.PbrStanNavigation)
                .Include(n => n.SifOrgjedNavigation)
                .Include(n => n.PredNastavnik)
                    .ThenInclude(n => n.Predmet)
                .FirstOrDefaultAsync(m => m.SifNastavnik == id);
            if (nastavnik == null)
            {
                return NotFound();
            }

            return View(nastavnik);
        }

        // GET: Nastavniks/Create
        public IActionResult Create()
        {
            ViewData["PbrStan"] = new SelectList(_context.Mjesto, "Pbr", "NazMjesto");
            ViewData["SifOrgjed"] = new SelectList(_context.Orgjed, "SifOrgjed", "NazOrgjed");
            return View();
        }

        // POST: Nastavniks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SifNastavnik,ImeNastavnik,PrezNastavnik,PbrStan,SifOrgjed,Koef")] Nastavnik nastavnik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nastavnik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PbrStan"] = new SelectList(_context.Mjesto, "Pbr", "NazMjesto", nastavnik.PbrStan);
            ViewData["SifOrgjed"] = new SelectList(_context.Orgjed, "SifOrgjed", "NazOrgjed", nastavnik.SifOrgjed);
            return View(nastavnik);
        }

        // GET: Nastavniks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nastavnik = await _context.Nastavnik.FindAsync(id);
            if (nastavnik == null)
            {
                return NotFound();
            }
            ViewData["PbrStan"] = new SelectList(_context.Mjesto, "Pbr", "NazMjesto", nastavnik.PbrStan);
            ViewData["SifOrgjed"] = new SelectList(_context.Orgjed, "SifOrgjed", "NazOrgjed", nastavnik.SifOrgjed);
            return View(nastavnik);
        }

        // POST: Nastavniks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SifNastavnik,ImeNastavnik,PrezNastavnik,PbrStan,SifOrgjed,Koef")] Nastavnik nastavnik)
        {
            if (id != nastavnik.SifNastavnik)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nastavnik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NastavnikExists(nastavnik.SifNastavnik))
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
            ViewData["PbrStan"] = new SelectList(_context.Mjesto, "Pbr", "NazMjesto", nastavnik.PbrStan);
            ViewData["SifOrgjed"] = new SelectList(_context.Orgjed, "SifOrgjed", "NazOrgjed", nastavnik.SifOrgjed);
            return View(nastavnik);
        }

        // GET: Nastavniks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nastavnik = await _context.Nastavnik
                .Include(n => n.PbrStanNavigation)
                .Include(n => n.SifOrgjedNavigation)
                .FirstOrDefaultAsync(m => m.SifNastavnik == id);
            if (nastavnik == null)
            {
                return NotFound();
            }

            return View(nastavnik);
        }

        // POST: Nastavniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nastavnik = await _context.Nastavnik.FindAsync(id);
            _context.Nastavnik.Remove(nastavnik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NastavnikExists(int id)
        {
            return _context.Nastavnik.Any(e => e.SifNastavnik == id);
        }
    }
}
