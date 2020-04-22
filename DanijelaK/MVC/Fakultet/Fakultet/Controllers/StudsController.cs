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
    public class StudsController : Controller
    {
        private readonly FakultetContext _context;

        public StudsController(FakultetContext context)
        {
            _context = context;
        }

        // GET: Studs
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            var fakultetContext = from s
                                  in _context.Stud.Include(s => s.PbrRodNavigation)
                                  .Include(s => s.PbrStanNavigation)
                                  select s;

            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["LastNameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "last_name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["currentFilter"] = String.IsNullOrEmpty(searchString) ? "" : searchString;

            //var students = from s in _context.Stud select s;

            switch (sortOrder)
            {
                case "name_desc":
                    fakultetContext = fakultetContext.OrderByDescending(s => s.ImeStud);
                    break;
                case "last_name_desc":
                    fakultetContext = fakultetContext.OrderByDescending(s => s.PrezStud);
                    break;
                case "Date":
                    fakultetContext = fakultetContext.OrderBy(s => s.DatRodStud);
                    break;
                case "date_desc":
                    fakultetContext = fakultetContext.OrderByDescending(s => s.DatRodStud);
                    break;
                default:
                    fakultetContext = fakultetContext.OrderBy(s => s.PrezStud);
                    break;
            }

            if (!String.IsNullOrEmpty(searchString))
            {
                fakultetContext = fakultetContext.Where(
                    s => s.PrezStud.Contains(searchString)
                    || s.ImeStud.Contains(searchString));
            }

            return View(await fakultetContext.AsNoTracking().ToListAsync());


            //return View(await fakultetContext.ToListAsync());
        }

        // GET: Studs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stud = await _context.Stud
                .Include(s => s.PbrRodNavigation)
                .Include(s => s.PbrStanNavigation)
                .FirstOrDefaultAsync(m => m.MbrStud == id);
            if (stud == null)
            {
                return NotFound();
            }

            return View(stud);
        }

        // GET: Studs/Create
        public IActionResult Create()
        {
            ViewData["PbrRod"] = new SelectList(_context.Mjesto, "Pbr", "NazMjesto");
            ViewData["PbrStan"] = new SelectList(_context.Mjesto, "Pbr", "NazMjesto");
            return View();
        }

        // POST: Studs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MbrStud,ImeStud,PrezStud,PbrRod,PbrStan,DatRodStud,JmbgStud")] Stud stud)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stud);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PbrRod"] = new SelectList(_context.Mjesto, "Pbr", "NazMjesto", stud.PbrRod);
            ViewData["PbrStan"] = new SelectList(_context.Mjesto, "Pbr", "NazMjesto", stud.PbrStan);
            return View(stud);
        }

        // GET: Studs/Edit/5  // samo prikazuje formu
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stud = await _context.Stud.FindAsync(id);
            if (stud == null)
            {
                return NotFound();
            }
            ViewData["PbrRod"] = new SelectList(_context.Mjesto, "Pbr", "NazMjesto", stud.PbrRod);
            ViewData["PbrStan"] = new SelectList(_context.Mjesto, "Pbr", "NazMjesto", stud.PbrStan);
            return View(stud);
        }

        // POST: Studs/Edit/5  // Prima podatke sa forme i obradjuje ih
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MbrStud,ImeStud,PrezStud,PbrRod,PbrStan,DatRodStud,JmbgStud")] Stud stud)
        {
            if (id != stud.MbrStud)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stud);              // ovo sprema u context
                    await _context.SaveChangesAsync(); // ovo sprema u bazu 
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudExists(stud.MbrStud))
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
            ViewData["PbrRod"] = new SelectList(_context.Mjesto, "Pbr", "NazMjesto", stud.PbrRod);
            ViewData["PbrStan"] = new SelectList(_context.Mjesto, "Pbr", "NazMjesto", stud.PbrStan);
            return View(stud);
        }

        // GET: Studs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stud = await _context.Stud
                .Include(s => s.PbrRodNavigation)
                .Include(s => s.PbrStanNavigation)
                .FirstOrDefaultAsync(m => m.MbrStud == id);
            if (stud == null)
            {
                return NotFound();
            }

            return View(stud);
        }

        // POST: Studs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stud = await _context.Stud.FindAsync(id);
            _context.Stud.Remove(stud);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudExists(int id)
        {
            return _context.Stud.Any(e => e.MbrStud == id);
        }
    }
}