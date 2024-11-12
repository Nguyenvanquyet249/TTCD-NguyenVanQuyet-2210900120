using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using K22CNT4_NguyenVanQuyet_Project2.Models;

namespace K22CNT4_NguyenVanQuyet_Project2.Controllers
{
    public class NVQ_San_PhamController : Controller
    {
        private NVQDbEntities db = new NVQDbEntities();

        // GET: NVQ_San_Pham
        public ActionResult Index()
        {
            var san_Pham = db.San_Pham.Include(s => s.Hang_San_Xuat);
            return View(san_Pham.ToList());
        }

        // GET: NVQ_San_Pham/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            San_Pham san_Pham = db.San_Pham.Find(id);
            if (san_Pham == null)
            {
                return HttpNotFound();
            }
            return View(san_Pham);
        }

        // GET: NVQ_San_Pham/Create
        public ActionResult Create()
        {
            ViewBag.id_hang = new SelectList(db.Hang_San_Xuat, "id_hang", "ten_hang");
            return View();
        }

        // POST: NVQ_San_Pham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_sp,ten_sp,id_hang,mo_ta,gia,so_luong_ton,ngay_tao")] San_Pham san_Pham)
        {
            if (ModelState.IsValid)
            {
                db.San_Pham.Add(san_Pham);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_hang = new SelectList(db.Hang_San_Xuat, "id_hang", "ten_hang", san_Pham.id_hang);
            return View(san_Pham);
        }

        // GET: NVQ_San_Pham/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            San_Pham san_Pham = db.San_Pham.Find(id);
            if (san_Pham == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_hang = new SelectList(db.Hang_San_Xuat, "id_hang", "ten_hang", san_Pham.id_hang);
            return View(san_Pham);
        }

        // POST: NVQ_San_Pham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_sp,ten_sp,id_hang,mo_ta,gia,so_luong_ton,ngay_tao")] San_Pham san_Pham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(san_Pham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_hang = new SelectList(db.Hang_San_Xuat, "id_hang", "ten_hang", san_Pham.id_hang);
            return View(san_Pham);
        }

        // GET: NVQ_San_Pham/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            San_Pham san_Pham = db.San_Pham.Find(id);
            if (san_Pham == null)
            {
                return HttpNotFound();
            }
            return View(san_Pham);
        }

        // POST: NVQ_San_Pham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            San_Pham san_Pham = db.San_Pham.Find(id);
            db.San_Pham.Remove(san_Pham);
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
