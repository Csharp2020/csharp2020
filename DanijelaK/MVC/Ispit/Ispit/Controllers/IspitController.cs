using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ispit.Models;

namespace Ispit.Controllers
{
    public class IspitController : Controller
    {
        private readonly PokloniContext _context;

        public IspitController(PokloniContext context)
        {
            _context = context;
        }

        // GET: Ispit
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pokloni.ToListAsync());
        }
      
        public ActionResult prvi()
        {
            return View();
        }

        // GET: Ispit/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokloni = await _context.Pokloni
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pokloni == null)
            {
                return NotFound();
            }

            return View(pokloni);
        }

        // GET: Ispit/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ispit/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NazivPoklona,Iznos,Kupljeno")] Pokloni pokloni)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pokloni);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pokloni);
        }

        // GET: Ispit/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokloni = await _context.Pokloni.FindAsync(id);
            if (pokloni == null)
            {
                return NotFound();
            }
            return View(pokloni);
        }

        // POST: Ispit/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NazivPoklona,Iznos,Kupljeno")] Pokloni pokloni)
        {
            if (id != pokloni.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pokloni);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PokloniExists(pokloni.Id))
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
            return View(pokloni);
        }

        // GET: Ispit/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokloni = await _context.Pokloni
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pokloni == null)
            {
                return NotFound();
            }

            return View(pokloni);
        }

        // POST: Ispit/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pokloni = await _context.Pokloni.FindAsync(id);
            _context.Pokloni.Remove(pokloni);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PokloniExists(int id)
        {
            return _context.Pokloni.Any(e => e.Id == id);
        }
    }
}
