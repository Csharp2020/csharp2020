using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firma.Models;
using Microsoft.AspNetCore.Mvc;

namespace Firma.Controllers
{
    public class VoceController : Controller
    {       
        public IActionResult Plati()
        {
            ViewBag.Placeno = true;
            return View("Index", HttpContext.Session.Get<List<Voce>>("kosarica"));
           
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult UnosVoca() // Ovdje ce biti forma za unos
        {
            return View();
        }
        [HttpPost]
        public IActionResult UnosVoca(Voce voce) // Ovdje ce biti obrada unosa
        {
            // pripremimo listu
            List<Voce> kosarica = new List<Voce>();

            // ukoliko vec postoji iz sessiona, popunimo ju s tim vrijedniostima
            if(HttpContext.Session.Get<List<Voce>>("kosarica") != null)
            {
                kosarica = HttpContext.Session.Get<List<Voce>>("kosarica");
            }
            
            // dodaj voce u kosaricu
            kosarica.Add(voce);

            // dodaj kosaricu u session
            HttpContext.Session.Set<List<Voce>>("kosarica", kosarica);

            // proslijedi kosaricu na ispis
            return View("Index",kosarica);
        }

    }
}