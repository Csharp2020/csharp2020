using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _5_3_1.Controllers
{
    public class LayoutSectionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Stranica1()
        {
            return View();
        }

        public IActionResult Stranica2()
        {
            return View();
        }
    }
}