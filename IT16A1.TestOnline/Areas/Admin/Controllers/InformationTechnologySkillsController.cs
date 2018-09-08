using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IT16A1.TestOnline.Areas.Admin.Models;

namespace IT16A1.TestOnline.Areas.Admin.Controllers
{
    public class InformationTechnologySkillsController : Controller
    {
        private OnlineQuizDbContext db = new OnlineQuizDbContext();

        // GET: Admin/InformationTechnologySkills
        public ActionResult Index()
        {
            return View(db.InformationTechnologySkills.ToList());
        }

        // GET: Admin/InformationTechnologySkills/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformationTechnologySkill informationTechnologySkill = db.InformationTechnologySkills.Find(id);
            if (informationTechnologySkill == null)
            {
                return HttpNotFound();
            }
            return View(informationTechnologySkill);
        }

        // GET: Admin/InformationTechnologySkills/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/InformationTechnologySkills/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] InformationTechnologySkill informationTechnologySkill)
        {
            if (ModelState.IsValid)
            {
                informationTechnologySkill.ID = Guid.NewGuid();
                db.InformationTechnologySkills.Add(informationTechnologySkill);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(informationTechnologySkill);
        }

        // GET: Admin/InformationTechnologySkills/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformationTechnologySkill informationTechnologySkill = db.InformationTechnologySkills.Find(id);
            if (informationTechnologySkill == null)
            {
                return HttpNotFound();
            }
            return View(informationTechnologySkill);
        }

        // POST: Admin/InformationTechnologySkills/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] InformationTechnologySkill informationTechnologySkill)
        {
            if (ModelState.IsValid)
            {
                db.Entry(informationTechnologySkill).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(informationTechnologySkill);
        }

        // GET: Admin/InformationTechnologySkills/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InformationTechnologySkill informationTechnologySkill = db.InformationTechnologySkills.Find(id);
            if (informationTechnologySkill == null)
            {
                return HttpNotFound();
            }
            return View(informationTechnologySkill);
        }

        // POST: Admin/InformationTechnologySkills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            InformationTechnologySkill informationTechnologySkill = db.InformationTechnologySkills.Find(id);
            db.InformationTechnologySkills.Remove(informationTechnologySkill);
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
