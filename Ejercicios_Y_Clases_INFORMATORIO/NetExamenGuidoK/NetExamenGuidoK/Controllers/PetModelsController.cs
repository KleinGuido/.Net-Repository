using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NetExamGuido.Models;
using NetExamenGuidoK.Models;

namespace NetExamenGuidoK.Controllers
{
    public class PetModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PetModels
        public ActionResult Index()
        {
            return View(db.PetModels.ToList());
        }

        // GET: PetModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetModels petModels = db.PetModels.Find(id);
            if (petModels == null)
            {
                return HttpNotFound();
            }
            return View(petModels);
        }

        // GET: PetModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PetModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Name,Breed,DateOfBirth,State,Animal")] PetModels petModels)
        {
            if (ModelState.IsValid)
            {
                db.PetModels.Add(petModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(petModels);
        }

        // GET: PetModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetModels petModels = db.PetModels.Find(id);
            if (petModels == null)
            {
                return HttpNotFound();
            }
            return View(petModels);
        }

        // POST: PetModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name,Breed,DateOfBirth,State,Animal")] PetModels petModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(petModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(petModels);
        }

        // GET: PetModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetModels petModels = db.PetModels.Find(id);
            if (petModels == null)
            {
                return HttpNotFound();
            }
            return View(petModels);
        }

        // POST: PetModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PetModels petModels = db.PetModels.Find(id);
            db.PetModels.Remove(petModels);
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
