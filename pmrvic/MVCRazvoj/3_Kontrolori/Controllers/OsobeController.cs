using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _3_Kontrolori.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3_Kontrolori.Controllers
{
    public class OsobeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PopuniOsobu()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PrikaziOsobu(Osoba osoba)
        {
            List<Osoba> listica = new List<Osoba>();
            
            if (HttpContext.Session.Get<List<Osoba>>("ListaOsoba")!=null)
            {
                listica = HttpContext.Session.Get<List<Osoba>>("ListaOsoba");
            }
            
            listica.Add(osoba);
           
            HttpContext.Session.Set<List<Osoba>>("ListaOsoba", listica);



            HttpContext.Session.SetString("NekoIme","Dubravka");            
            ViewBag.name = HttpContext.Session.GetString("NekoIme");
            ViewBag.ListaOsoba= HttpContext.Session.Get<List<Osoba>>("ListaOsoba");

            return View(osoba);

        }
    }
}