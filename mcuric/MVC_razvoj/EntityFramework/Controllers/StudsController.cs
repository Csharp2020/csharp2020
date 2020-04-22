using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EntityFramework.Models;
using EntityFramework.Lib;

namespace EntityFramework.Controllers
{
    public class StudsController : Controller
    {
        private readonly fakultetContext _context;

        public StudsController(fakultetContext context)
        {
            _context = context;
        }

        // GET: Studs
        /* public async Task<IActionResult> Index()
         {
             var fakultetContext = _context.Stud.Include(s => s.PbrRodNavigation).Include(s => s.PbrStanNavigation);
             return View(await fakultetContext.ToListAsync());
         } */

        public async Task<IActionResult> Index(string sortOrder, string searchString, string currentFilter, int? pageNumber)
        {
            //var fakultetContext = _context.Stud.Include(s => s.PbrRodNavigation).Include(s => s.PbrStanNavigation);
            //return View(await fakultetContext.ToListAsync());
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["LastNameSortParm"] = sortOrder == "lastname_asc" ? "lastname_desc" : "lastname_asc";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            //ViewData["CurrentFilter"] = searchString;
            ViewData["CurrentSort"] = sortOrder;
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            var students = from s in _context.Stud
                           select s;
            ViewData["Total"] = students.Count();
            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.PrezStud.Contains(searchString)
                                       || s.ImeStud.Contains(searchString));
            }
            ViewData["Count"] = students.Count();
            switch (sortOrder)
            {
                case "name_desc":
                    students = students.OrderByDescending(s => s.ImeStud).Include(s => s.PbrRodNavigation).Include(s => s.PbrStanNavigation);
                    break;
                case "lastname_asc":
                    students = students.OrderBy(s => s.PrezStud).Include(s => s.PbrRodNavigation).Include(s => s.PbrStanNavigation);
                    break;
                case "Date":
                    students = students.OrderBy(s => s.DatRodStud).Include(s => s.PbrRodNavigation).Include(s => s.PbrStanNavigation);
                    break;
                case "date_desc":
                    students = students.OrderByDescending(s => s.DatRodStud).Include(s => s.PbrRodNavigation).Include(s => s.PbrStanNavigation);
                    break;
                case "lastname_desc":
                    students = students.OrderByDescending(s => s.PrezStud).Include(s => s.PbrRodNavigation).Include(s => s.PbrStanNavigation);
                    break;
                default:
                    students = students.OrderBy(s => s.ImeStud).Include(s => s.PbrRodNavigation).Include(s => s.PbrStanNavigation);
                    break;
            }
            //return View(await students.AsNoTracking().ToListAsync());
            int pageSize = 20;
            ViewData["CurrentPageNo"] = pageNumber;
            ViewData["TotalPages"] = Math.Ceiling(students.Count()/(double)20);
            return View(await PaginatedList<Stud>.CreateAsync(students.AsNoTracking(), pageNumber ?? 1, pageSize));
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

        // GET: Studs/Edit/5
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

        // POST: Studs/Edit/5
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
                    _context.Update(stud);
                    await _context.SaveChangesAsync();
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
