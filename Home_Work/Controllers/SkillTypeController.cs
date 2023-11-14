using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Home_Work.Models;

namespace Home_Work.Controllers
{
    public class SkillTypeController : Controller
    {
        private HomeWorkDBEntities db = new HomeWorkDBEntities();

        // GET: SkillType
        public async Task<ActionResult> Index()
        {
            return View(await db.Job_SkillType.ToListAsync());
        }

        // GET: SkillType/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job_SkillType job_SkillType = await db.Job_SkillType.FindAsync(id);
            if (job_SkillType == null)
            {
                return HttpNotFound();
            }
            return View(job_SkillType);
        }

        // GET: SkillType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SkillType/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name")] Job_SkillType job_SkillType)
        {
            if (ModelState.IsValid)
            {
                db.Job_SkillType.Add(job_SkillType);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(job_SkillType);
        }

        // GET: SkillType/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job_SkillType job_SkillType = await db.Job_SkillType.FindAsync(id);
            if (job_SkillType == null)
            {
                return HttpNotFound();
            }
            return View(job_SkillType);
        }

        // POST: SkillType/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name")] Job_SkillType job_SkillType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(job_SkillType).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(job_SkillType);
        }

        // GET: SkillType/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job_SkillType job_SkillType = await db.Job_SkillType.FindAsync(id);
            if (job_SkillType == null)
            {
                return HttpNotFound();
            }
            return View(job_SkillType);
        }

        // POST: SkillType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Job_SkillType job_SkillType = await db.Job_SkillType.FindAsync(id);
            db.Job_SkillType.Remove(job_SkillType);
            await db.SaveChangesAsync();
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
