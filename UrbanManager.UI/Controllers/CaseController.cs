﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UrbanManager.UI.Controllers
{
    /// <summary>
    /// 案件基本信息
    /// </summary>
    public class CaseController : Controller
    {
        // GET: Case
        public ActionResult Index()
        {
            return View();
        }

        // GET: Case/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Case/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Case/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Case/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Case/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Case/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Case/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
