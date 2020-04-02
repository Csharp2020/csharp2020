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
            listica.Add(osoba);
            string SessionName = null;
        
          //  HttpContext.Session.SetString(SessionName, "Jarvik");
            // Session["PodaciOsobe"] = listica;
            return View(osoba);
        }
    }
}