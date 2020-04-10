using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _5_2_2.Controllers
{
    public class KalkulatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Izracunaj()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Izracunaj(double a, double b, string operacija)
        {
            ViewBag.prviBroj = a;
            ViewBag.drugiBroj = b;
            return View((object)operacija);
        }
    }
}