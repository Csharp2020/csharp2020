using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFramework.Factory;
using EntityFramework.Models;
using EntityFramework.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace EntityFramework.Controllers
{
    public class TODOController : Controller
    {
        private readonly IOptions<MySettingsModel> appSettings;
        public TODOController(IOptions<MySettingsModel> app)
        {
            appSettings = app;
            //ApplicationSettings.WebApiUrl = appSettings.Value.WebApiBaseUrl;
            ApplicationSettings.WebApiUrl = "https://localhost:44372/api/";
        }
        // GET: TODO
        // prikazuje sve TODO iteme
        public async Task<IActionResult> Index()
        {
            var data = await ApiClientFactory.Instance.GetUsers();
            return View();
        }

        // GET: TODO/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TODO/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TODO/Create
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

        // GET: TODO/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TODO/Edit/5
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

        // GET: TODO/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TODO/Delete/5
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