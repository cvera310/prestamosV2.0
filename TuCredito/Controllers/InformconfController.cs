using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TuCredito.Models;

namespace TuCredito.Controllers
{
    public class InformconfController : Controller
    {
        private prestamoEntities db = new prestamoEntities();

        // GET: Informconf
        public ActionResult Index()
        {
            return View(db.Informconf.ToList());
        }

        // GET: Informconf/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Informconf informconf = db.Informconf.Find(id);
            if (informconf == null)
            {
                return HttpNotFound();
            }
            return View(informconf);
        }

        // GET: Informconf/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Informconf/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Documento,Nombre,Apellido,RazonSocial,Informconf1,Faja")] Informconf informconf)
        {
            if (ModelState.IsValid)
            {
                db.Informconf.Add(informconf);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(informconf);
        }

        // GET: Informconf/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Informconf informconf = db.Informconf.Find(id);
            if (informconf == null)
            {
                return HttpNotFound();
            }
            return View(informconf);
        }

        // POST: Informconf/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Documento,Nombre,Apellido,RazonSocial,Informconf1,Faja")] Informconf informconf)
        {
            if (ModelState.IsValid)
            {
                db.Entry(informconf).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(informconf);
        }

        // GET: Informconf/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Informconf informconf = db.Informconf.Find(id);
            if (informconf == null)
            {
                return HttpNotFound();
            }
            return View(informconf);
        }

        // POST: Informconf/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Informconf informconf = db.Informconf.Find(id);
            db.Informconf.Remove(informconf);
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
