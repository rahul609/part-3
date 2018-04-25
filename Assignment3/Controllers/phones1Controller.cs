using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment3.Models;

namespace Assignment3.Controllers
{
    public class phones1Controller : Controller
    {
        // db connection moved to EFphones1Repository
        //private Model1 db = new Model1();
        private IMockphones1Repository db;

        // default constructor - no dependency incoming => use the database

            public phones1Controller()
        {


            this.db = new EFphones1Repository();

        }

        // mock constructor - mock object passed as a dependency for unit testing

            public phones1Controller(IMockphones1Repository mockRepo)
        {

            this.db = mockRepo;

        }
        // GET: phones1
        public ActionResult Index()
        {
            return View(db.Phones1.ToList());
        }

        //// GET: phones1/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    phones1 phones1 = db.phones1.Find(id);
        //    if (phones1 == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(phones1);
        //}

        //// GET: phones1/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: phones1/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "phoneID,phones,color")] phones1 phones1)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.phones1.Add(phones1);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(phones1);
        //}

        //// GET: phones1/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    phones1 phones1 = db.phones1.Find(id);
        //    if (phones1 == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(phones1);
        //}

        //// POST: phones1/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "phoneID,phones,color")] phones1 phones1)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(phones1).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(phones1);
        //}

        //// GET: phones1/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    phones1 phones1 = db.phones1.Find(id);
        //    if (phones1 == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(phones1);
        //}

        //// POST: phones1/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    phones1 phones1 = db.phones1.Find(id);
        //    db.phones1.Remove(phones1);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
