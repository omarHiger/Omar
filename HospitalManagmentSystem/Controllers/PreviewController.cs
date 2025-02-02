﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagmentSystem.Controllers
{
    public class PreviewController : Controller
    {
        // GET: PreviewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PreviewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PreviewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PreviewController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PreviewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PreviewController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PreviewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PreviewController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
