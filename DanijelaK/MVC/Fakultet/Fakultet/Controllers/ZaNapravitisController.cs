﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Fakultet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fakultet.Controllers
{
    public class ZaNapravitisController : Controller
    {
        // GET: ZaNapravitis
        /*
         * Ovo prikazuje sve TODOItems 
         * https://localhost:5001/api/TodoItems
         * */
        public async Task<IActionResult> Index()
        {
           var data = await
           return View();
        }

        // GET: ZaNapravitis/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ZaNapravitis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ZaNapravitis/Create
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

        // GET: ZaNapravitis/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ZaNapravitis/Edit/5
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

        // GET: ZaNapravitis/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ZaNapravitis/Delete/5
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