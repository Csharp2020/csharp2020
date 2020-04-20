using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Faxi.Models;

namespace Faxi.Controllers
{
    public class PrijateljisController : Controller
    {
        private readonly videotekaContext _context;

        public PrijateljisController(videotekaContext context)
        {
            _context = context;
        }

        // GET: Prijateljis
        public async Task<IActionResult> Index()
        {
            return View(await _context.Prijatelji.ToListAsync());
        }

        // GET: Prijateljis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prijatelji = await _context.Prijatelji
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prijatelji == null)
            {
                return NotFound();
            }

            return View(prijatelji);
        }

        // GET: Prijateljis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Prijateljis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ime,Prezime")] Prijatelji prijatelji)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prijatelji);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(prijatelji);
        }

        // GET: Prijateljis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prijatelji = await _context.Prijatelji.FindAsync(id);
            if (prijatelji == null)
            {
                return NotFound();
            }
            return View(prijatelji);
        }

        // POST: Prijateljis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ime,Prezime")] Prijatelji prijatelji)
        {
            if (id != prijatelji.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prijatelji);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrijateljiExists(prijatelji.Id))
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
            return View(prijatelji);
        }

        // GET: Prijateljis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prijatelji = await _context.Prijatelji
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prijatelji == null)
            {
                return NotFound();
            }

            return View(prijatelji);
        }

        // POST: Prijateljis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prijatelji = await _context.Prijatelji.FindAsync(id);
            _context.Prijatelji.Remove(prijatelji);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrijateljiExists(int id)
        {
            return _context.Prijatelji.Any(e => e.Id == id);
        }
    }
}
