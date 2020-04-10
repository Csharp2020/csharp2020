using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _5_2_1.Controllers
{
    public class SlucajniBrojController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RavrstajSlucajniBroj()
        {
            Random rand = new Random();
            int slucajni = rand.Next(1, 1000);
            return View((object)slucajni);
        }
    }
}