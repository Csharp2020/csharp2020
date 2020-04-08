using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _4_1_1.Controllers
{
    public class TocanOdgovorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProvjeriOdgovor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProvjeriOdgovor(string rb)
        {
            string poruka1 = "Odgovor je točan!";
            string poruka2 = "Odgovor NIJE točan!";
            if (rb == "rb3")
                return View((object)poruka1);
            else
                return View((object)poruka2);
        }
    }
}