using Business;
using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class AttendController : Controller
    {
        private AttendManager attendManager = new AttendManager();
        // GET: Attend
        public ActionResult Index()
        {
            var attendsList = this.attendManager.FindAll();

            return View(attendsList.ToList());
        }

        // GET: Attend/Details/5
        public ActionResult Details(int id)
        {
            Attend AttendsList = this.attendManager.Find(id);

            if (AttendsList == null)
            {
                return HttpNotFound();
            }

            return View(AttendsList);
        }

        // GET: Attend/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(this.attendManager.EmployeeList, "Id", "Name");
            return View();
        }

        // POST: Attend/Create
        [HttpPost]
        public ActionResult Create(Attend AttendsList)
        {
            if (ModelState.IsValid)
            {
                this.attendManager.Save(AttendsList);
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(this.attendManager.EmployeeList, "Id", "Description");
            return View(AttendsList);
        }

        // GET: Attend/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Attend/Edit/5
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

        // GET: Attend/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Attend/Delete/5
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
