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
    public class QuestionModulesController : Controller
    {
        private OnlineQuizDbContext db = new OnlineQuizDbContext();

        // GET: Admin/QuestionModules
        public ActionResult Index()
        {
            var questionModules = db.QuestionModules.Include(q => q.InformationTechnologySkill);
            return View(questionModules.ToList());
        }

        // GET: Admin/QuestionModules/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionModule questionModule = db.QuestionModules.Find(id);
            if (questionModule == null)
            {
                return HttpNotFound();
            }
            return View(questionModule);
        }

        // GET: Admin/QuestionModules/Create
        public ActionResult Create()
        {
            ViewBag.InformationTechnologySkillID = new SelectList(db.InformationTechnologySkills, "ID", "Name");
            return View();
        }

        // POST: Admin/QuestionModules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,InformationTechnologySkillID,Name,Quantity,Remark")] QuestionModule questionModule)
        {
            if (ModelState.IsValid)
            {
                questionModule.ID = Guid.NewGuid();
                db.QuestionModules.Add(questionModule);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.InformationTechnologySkillID = new SelectList(db.InformationTechnologySkills, "ID", "Name", questionModule.InformationTechnologySkillID);
            return View(questionModule);
        }

        // GET: Admin/QuestionModules/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionModule questionModule = db.QuestionModules.Find(id);
            if (questionModule == null)
            {
                return HttpNotFound();
            }
            ViewBag.InformationTechnologySkillID = new SelectList(db.InformationTechnologySkills, "ID", "Name", questionModule.InformationTechnologySkillID);
            return View(questionModule);
        }

        // POST: Admin/QuestionModules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,InformationTechnologySkillID,Name,Quantity,Remark")] QuestionModule questionModule)
        {
            if (ModelState.IsValid)
            {
                db.Entry(questionModule).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.InformationTechnologySkillID = new SelectList(db.InformationTechnologySkills, "ID", "Name", questionModule.InformationTechnologySkillID);
            return View(questionModule);
        }

        // GET: Admin/QuestionModules/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionModule questionModule = db.QuestionModules.Find(id);
            if (questionModule == null)
            {
                return HttpNotFound();
            }
            return View(questionModule);
        }

        // POST: Admin/QuestionModules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            QuestionModule questionModule = db.QuestionModules.Find(id);
            db.QuestionModules.Remove(questionModule);
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
