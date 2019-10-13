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
    public class monedaController : Controller
    {
        private prestamoEntities db = new prestamoEntities();

        // GET: moneda
        public ActionResult Index()
        {
            return View(db.moneda.ToList());
        }

        // GET: moneda/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            moneda moneda = db.moneda.Find(id);
            if (moneda == null)
            {
                return HttpNotFound();
            }
            return View(moneda);
        }

        // GET: moneda/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: moneda/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "mon_codigo,mon_descripcion,mon_pais")] moneda moneda)
        {
            if (ModelState.IsValid)
            {
                db.moneda.Add(moneda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(moneda);
        }

        // GET: moneda/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            moneda moneda = db.moneda.Find(id);
            if (moneda == null)
            {
                return HttpNotFound();
            }
            return View(moneda);
        }

        // POST: moneda/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "mon_codigo,mon_descripcion,mon_pais")] moneda moneda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(moneda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(moneda);
        }

        // GET: moneda/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            moneda moneda = db.moneda.Find(id);
            if (moneda == null)
            {
                return HttpNotFound();
            }
            return View(moneda);
        }

        // POST: moneda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            moneda moneda = db.moneda.Find(id);
            db.moneda.Remove(moneda);
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
