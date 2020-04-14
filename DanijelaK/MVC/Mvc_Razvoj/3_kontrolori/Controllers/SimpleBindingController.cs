using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _3_Kontrolori.Controllers
{
    public class SimpleBindingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet] //ovo mogu i ne moram pisati jer je get defaultna metoda
        public IActionResult SimpleBind()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SimpleBind(string ime)
        {

            return View((object)ime);
        }
        [HttpPost]
        public IActionResult SimpleBindEngleski(string ime)
        {
            ime = "Welcome " + ime+", how are you? Tututrutu tu";
            return View("SimpleBind",(object)ime);
        }
    }
}