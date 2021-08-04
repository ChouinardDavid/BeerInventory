using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeerInventory.Controllers
{
    public class autreController : Controller
    {
        // GET: autre
        public ActionResult Index()
        {
            return View();
        }

        // GET: autre/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: autre/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: autre/Create
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

        // GET: autre/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: autre/Edit/5
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

        // GET: autre/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: autre/Delete/5
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
