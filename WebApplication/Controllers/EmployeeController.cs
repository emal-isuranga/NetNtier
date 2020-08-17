using Business;
using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeManager employeeManager = new EmployeeManager();

        // GET: Employee
        public ActionResult Index()
        {
            return View(this.employeeManager.FindAll().ToList());
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id = 0)
        {
            Employee EmployeeList = this.employeeManager.Find(id);

            if (EmployeeList == null)
            {
                return HttpNotFound();
            }

            return View(EmployeeList);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee EmployeeList)
        {
            try
            {
                // TODO: Add insert logic here
                this.employeeManager.Save(EmployeeList);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(EmployeeList);
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            Employee EmployeeList = this.employeeManager.Find(id);
            if (EmployeeList == null)
            {
                return HttpNotFound();
            }
            return View(EmployeeList);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(Employee EmployeeList)
        {
            try
            {
                // TODO: Add update logic here
                this.employeeManager.Modify(EmployeeList);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(EmployeeList);
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            Employee EmployeeList = this.employeeManager.Find(id);
            if (EmployeeList == null)
            {
                return HttpNotFound();
            }

            return View(EmployeeList);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            this.employeeManager.Delete(id);
            return RedirectToAction("Index"); 
            
        }

        protected override void Dispose(bool disposing)
        {
            this.employeeManager.Dispose();
            base.Dispose(disposing);
        }
    }
}
