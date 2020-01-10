using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NetCore3.Web.Controllers
{
    public class Default2Controller : Controller
    {
        // GET: Default2
        public ActionResult Index()
        {
            return View();
        }

        // GET: Default2/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Default2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Default2/Create
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

        // GET: Default2/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Default2/Edit/5
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

        // GET: Default2/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Default2/Delete/5
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