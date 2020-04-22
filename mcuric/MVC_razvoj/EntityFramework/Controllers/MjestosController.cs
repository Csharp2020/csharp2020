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
    public class MjestosController : Controller
    {
        private readonly fakultetContext _context;

        public MjestosController(fakultetContext context)
        {
            _context = context;
        }

        // GET: Mjestos
        public async Task<IActionResult> Index()
        {
            var fakultetContext = _context.Mjesto.Include(m => m.SifZupanijaNavigation);
            return View(await fakultetContext.ToListAsync());
        }

        // GET: Mjestos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mjesto = await _context.Mjesto
                .Include(m => m.SifZupanijaNavigation)
                .FirstOrDefaultAsync(m => m.Pbr == id);
            if (mjesto == null)
            {
                return NotFound();
            }

            return View(mjesto);
        }

        // GET: Mjestos/Create
        public IActionResult Create()
        {
            ViewData["SifZupanija"] = new SelectList(_context.Zupanija, "SifZupanija", "NazZupanija");
            return View();
        }

        // POST: Mjestos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Pbr,NazMjesto,SifZupanija")] Mjesto mjesto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mjesto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SifZupanija"] = new SelectList(_context.Zupanija, "SifZupanija", "NazZupanija", mjesto.SifZupanija);
            return View(mjesto);
        }

        // GET: Mjestos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mjesto = await _context.Mjesto.FindAsync(id);
            if (mjesto == null)
            {
                return NotFound();
            }
            ViewData["SifZupanija"] = new SelectList(_context.Zupanija, "SifZupanija", "NazZupanija", mjesto.SifZupanija);
            return View(mjesto);
        }

        // POST: Mjestos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Pbr,NazMjesto,SifZupanija")] Mjesto mjesto)
        {
            if (id != mjesto.Pbr)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mjesto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MjestoExists(mjesto.Pbr))
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
            ViewData["SifZupanija"] = new SelectList(_context.Zupanija, "SifZupanija", "NazZupanija", mjesto.SifZupanija);
            return View(mjesto);
        }

        // GET: Mjestos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mjesto = await _context.Mjesto
                .Include(m => m.SifZupanijaNavigation)
                .FirstOrDefaultAsync(m => m.Pbr == id);
            if (mjesto == null)
            {
                return NotFound();
            }

            return View(mjesto);
        }

        // POST: Mjestos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mjesto = await _context.Mjesto.FindAsync(id);
            _context.Mjesto.Remove(mjesto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MjestoExists(int id)
        {
            return _context.Mjesto.Any(e => e.Pbr == id);
        }
    }
}
