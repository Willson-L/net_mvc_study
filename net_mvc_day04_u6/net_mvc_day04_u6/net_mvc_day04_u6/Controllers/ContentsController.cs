using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using net_mvc_day04_u6.Models;

namespace net_mvc_day04_u6.Controllers
{
    public class ContentsController : Controller
    {
        private net_mvc_day04_u6Context db = new net_mvc_day04_u6Context();

        // GET: Contents
        public ActionResult Index()
        {
            return View(db.Contents.ToList());
        }

        // GET: Contents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contents contents = db.Contents.Find(id);
            if (contents == null)
            {
                return HttpNotFound();
            }
            return View(contents);
        }

        // GET: Contents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contents/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,name,comtents")] Contents contents)
        {
            if (ModelState.IsValid)
            {
                db.Contents.Add(contents);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contents);
        }

        // GET: Contents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contents contents = db.Contents.Find(id);
            if (contents == null)
            {
                return HttpNotFound();
            }
            return View(contents);
        }

        // POST: Contents/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,name,comtents")] Contents contents)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contents).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contents);
        }

        // GET: Contents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contents contents = db.Contents.Find(id);
            if (contents == null)
            {
                return HttpNotFound();
            }
            return View(contents);
        }

        // POST: Contents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contents contents = db.Contents.Find(id);
            db.Contents.Remove(contents);
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
