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
    public class ProductsController : Controller
    {
        private ProductModel db = new ProductModel();

        // GET: Products
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Discount).Include(p => p.Manufacturer).Include(p => p.ProductsSection);
            return View(products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products products = db.Products.Find(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.DiscountId = new SelectList(db.Discount, "Id", "Name");
            ViewBag.MakerId = new SelectList(db.Manufacturer, "Id", "Name");
            ViewBag.SectionId = new SelectList(db.ProductsSection, "Id", "Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,MakerId,DiscountId,Price,SectionId")] Products products)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(products);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DiscountId = new SelectList(db.Discount, "Id", "Name", products.DiscountId);
            ViewBag.MakerId = new SelectList(db.Manufacturer, "Id", "Name", products.MakerId);
            ViewBag.SectionId = new SelectList(db.ProductsSection, "Id", "Name", products.SectionId);
            return View(products);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products products = db.Products.Find(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            ViewBag.DiscountId = new SelectList(db.Discount, "Id", "Name", products.DiscountId);
            ViewBag.MakerId = new SelectList(db.Manufacturer, "Id", "Name", products.MakerId);
            ViewBag.SectionId = new SelectList(db.ProductsSection, "Id", "Name", products.SectionId);
            return View(products);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,MakerId,DiscountId,Price,SectionId")] Products products)
        {
            if (ModelState.IsValid)
            {
                db.Entry(products).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DiscountId = new SelectList(db.Discount, "Id", "Name", products.DiscountId);
            ViewBag.MakerId = new SelectList(db.Manufacturer, "Id", "Name", products.MakerId);
            ViewBag.SectionId = new SelectList(db.ProductsSection, "Id", "Name", products.SectionId);
            return View(products);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products products = db.Products.Find(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Products products = db.Products.Find(id);
            db.Products.Remove(products);
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
