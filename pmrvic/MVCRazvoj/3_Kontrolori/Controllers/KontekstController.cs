using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _3_Kontrolori.Controllers
{
    public class KontekstController : Controller
    {
        public IActionResult Index()
        {
            DateTime datum = DateTime.Now;

            return View((object)datum);
        }
        
        /**
         * Nova sintaksa .NET CORE
         * */
        public IActionResult QueryPodaci(
            [FromQuery(Name = "ime")] string ime
            , [FromQuery(Name = "prezime")] string prezime)
        {
            // citaj ime i prezime iz querystringa
            // stara sintaksa is ASP.NET
            //Microsoft.AspNetCore.Http.QueryString qs =Request.QueryString;
            //= Request.QueryString["ime"];

            ViewBag.upit = Request.QueryString;
            ViewBag.upitlista = Request.Query;

            List<string> osobnoimeiprezime = new List<string>();
            osobnoimeiprezime.Add(ime);
            osobnoimeiprezime.Add(prezime);
            return View((object)osobnoimeiprezime);
        }

    }
}