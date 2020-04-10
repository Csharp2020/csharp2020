using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _4_1_1.Controllers
{
    public class BrojGodinaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RacunajBrojGodina()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RacunajBrojGodina(DateTime datum)
        {
            int brojGodina;
            try
            {
                brojGodina = (DateTime.Now - datum).Days / 365;
                return View((object)brojGodina.ToString());
            }
            catch (Exception ex)
            {
                return View((object)ex.Message);
            }
        }
    }
}