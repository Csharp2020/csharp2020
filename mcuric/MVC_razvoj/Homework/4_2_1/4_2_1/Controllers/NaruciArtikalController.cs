using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _4_2_1.Models;

namespace _4_2_1.Controllers
{
    public class NaruciArtikalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NaruciArtikal()
        {
            return View(new Artikl());
        }

        [HttpPost]
        public IActionResult NaruciArtikal(Artikl artikl)
        {
            if (artikl.Kolicina > 10)
                ViewBag.Message = "Nedovoljno robe na skladištu!";
            else
                ViewBag.Message = $"Narudžba uspješno zaprimljena! Ukupna cijena: ";
                return View(artikl);
        }
    }
}