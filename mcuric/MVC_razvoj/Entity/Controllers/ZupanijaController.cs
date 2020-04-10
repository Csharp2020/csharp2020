using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Entity.Controllers
{
    public class ZupanijaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}