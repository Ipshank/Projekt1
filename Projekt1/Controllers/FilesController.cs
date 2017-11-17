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
    public class FilesController : Controller
    {
        private FileDBCtxt db = new FileDBCtxt();

        // GET: Files
        public ActionResult Index()
        {
            var files = db.Files.Include(f => f.Album).Include(f => f.Genre).Include(f => f.Type1);
            return View(files.ToList());
        }

        // GET: Files/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            File file = db.Files.Find(id);
            if (file == null)
            {
                return HttpNotFound();
            }
            return View(file);
        }

        // GET: Files/Create
        public ActionResult Create()
        {
            ViewBag.AlbumID = new SelectList(db.Albums, "Id", "Name");
            ViewBag.GenreID = new SelectList(db.Genres, "Id", "Name");
            ViewBag.TypeID = new SelectList(db.Type1s, "Id", "Name");
            return View();
        }

        // POST: Files/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Path,Created,GenreID,TypeID,AlbumID")] File file)
        {
            if (ModelState.IsValid)
            {
                db.Files.Add(file);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AlbumID = new SelectList(db.Albums, "Id", "Name", file.AlbumID);
            ViewBag.GenreID = new SelectList(db.Genres, "Id", "Name", file.GenreID);
            ViewBag.TypeID = new SelectList(db.Type1s, "Id", "Name", file.Type1ID);
            return View(file);
        }

        // GET: Files/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            File file = db.Files.Find(id);
            if (file == null)
            {
                return HttpNotFound();
            }
            ViewBag.AlbumID = new SelectList(db.Albums, "Id", "Name", file.AlbumID);
            ViewBag.GenreID = new SelectList(db.Genres, "Id", "Name", file.GenreID);
            ViewBag.TypeID = new SelectList(db.Type1s, "Id", "Name", file.Type1ID);
            return View(file);
        }

        // POST: Files/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Path,Created,GenreID,TypeID,AlbumID")] File file)
        {
            if (ModelState.IsValid)
            {
                db.Entry(file).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AlbumID = new SelectList(db.Albums, "Id", "Name", file.AlbumID);
            ViewBag.GenreID = new SelectList(db.Genres, "Id", "Name", file.GenreID);
            ViewBag.TypeID = new SelectList(db.Type1s, "Id", "Name", file.Type1ID);
            return View(file);
        }

        // GET: Files/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            File file = db.Files.Find(id);
            if (file == null)
            {
                return HttpNotFound();
            }
            return View(file);
        }

        // POST: Files/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            File file = db.Files.Find(id);
            db.Files.Remove(file);
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
