using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Fakultet.Factory;
using Fakultet.Models;
using Fakultet.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Fakultet.Controllers
{
    public class ZaNapravitiController : Controller
    {
        private readonly IConfiguration Configuration;
        private readonly IOptions<MySettingsModel> appSettings;
        private readonly HttpClient _httpClient;
        public ZaNapravitiController(IOptions<MySettingsModel> app, IConfiguration configuration)
        {
            this.Configuration = configuration;
            appSettings = app;
           //TODO rijesi ovo sa settingsima
            // ApplicationSettings.WebApiUrl = appSettings.Value.WebApiBaseUrl;
       ApplicationSettings.WebApiUrl = "localhost:44385/api/";
        }
        
        // GET: ZaNapraviti
        /*
         * Ovo prikazuje sve TODOITEMS 
         * https://localhost:44385/api/TodoItems
         * */
        public async Task<IActionResult> Index()
        {
            var data = await ApiClientFactory.Instance.GetTODOS();
            //var response = await SaveUser();
            return View(data);
        }

        // GET: ZaNapraviti/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ZaNapraviti/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ZaNapraviti/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ZaNapraviti/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ZaNapraviti/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ZaNapraviti/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ZaNapraviti/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}