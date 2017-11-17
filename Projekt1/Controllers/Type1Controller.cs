using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Projekt1.Models;

namespace Projekt1.Controllers
{
    public class Type1Controller : Controller
    {
        private Type1DBctxt db = new Type1DBctxt();

        // GET: Type1
        public ActionResult Index()
        {
            return View(db.Type1s.ToList());
        }

        // GET: Type1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Type1 type1 = db.Type1s.Find(id);
            if (type1 == null)
            {
                return HttpNotFound();
            }
            return View(type1);
        }

        // GET: Type1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Type1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Type1 type1)
        {
            if (ModelState.IsValid)
            {
                db.Type1s.Add(type1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(type1);
        }

        // GET: Type1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Type1 type1 = db.Type1s.Find(id);
            if (type1 == null)
            {
                return HttpNotFound();
            }
            return View(type1);
        }

        // POST: Type1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Type1 type1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(type1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(type1);
        }

        // GET: Type1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Type1 type1 = db.Type1s.Find(id);
            if (type1 == null)
            {
                return HttpNotFound();
            }
            return View(type1);
        }

        // POST: Type1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Type1 type1 = db.Type1s.Find(id);
            db.Type1s.Remove(type1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
