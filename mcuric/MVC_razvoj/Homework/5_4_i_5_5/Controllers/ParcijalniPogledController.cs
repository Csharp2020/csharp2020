using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _5_4_i_5_5.Models;

namespace _5_4_i_5_5.Controllers
{
    public class ParcijalniPogledController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ObradiListu()
        {
            List<Artikl> lista = new List<Artikl>()
            {
                new Artikl {Naziv = "Mikrofon", Cijena = 5000},
                new Artikl {Naziv = "Stalak za mikrofon", Cijena = 250},
                new Artikl {Naziv = "Navlaka za mikrofon", Cijena = 100}
            };
            return View(lista);
        }
    }
}