using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShopyShop.Models;

namespace ShopyShop.Controllers
{
    public class ProductsSectionsController : Controller
    {
        private ProductModel db = new ProductModel();

        // GET: ProductsSections
        public ActionResult Index()
        {
            return View(db.ProductsSection.ToList());
        }

        // GET: ProductsSections/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductsSection productsSection = db.ProductsSection.Find(id);
            if (productsSection == null)
            {
                return HttpNotFound();
            }
            return View(productsSection);
        }

        // GET: ProductsSections/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsSections/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,VisibleName,ParentKey,Ord")] ProductsSection productsSection)
        {
            if (ModelState.IsValid)
            {
                db.ProductsSection.Add(productsSection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(productsSection);
        }

        // GET: ProductsSections/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductsSection productsSection = db.ProductsSection.Find(id);
            if (productsSection == null)
            {
                return HttpNotFound();
            }
            return View(productsSection);
        }

        // POST: ProductsSections/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,VisibleName,ParentKey,Ord")] ProductsSection productsSection)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productsSection).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(productsSection);
        }

        // GET: ProductsSections/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductsSection productsSection = db.ProductsSection.Find(id);
            if (productsSection == null)
            {
                return HttpNotFound();
            }
            return View(productsSection);
        }

        // POST: ProductsSections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductsSection productsSection = db.ProductsSection.Find(id);
            db.ProductsSection.Remove(productsSection);
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
