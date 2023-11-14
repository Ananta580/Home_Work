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
    public class WorkTypeController : Controller
    {
        private HomeWorkDBEntities db = new HomeWorkDBEntities();

        // GET: WorkType
        public async Task<ActionResult> Index()
        {
            return View(await db.Job_WorkType.ToListAsync());
        }

        // GET: WorkType/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job_WorkType job_WorkType = await db.Job_WorkType.FindAsync(id);
            if (job_WorkType == null)
            {
                return HttpNotFound();
            }
            return View(job_WorkType);
        }

        // GET: WorkType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkType/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name")] Job_WorkType job_WorkType)
        {
            if (ModelState.IsValid)
            {
                db.Job_WorkType.Add(job_WorkType);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(job_WorkType);
        }

        // GET: WorkType/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job_WorkType job_WorkType = await db.Job_WorkType.FindAsync(id);
            if (job_WorkType == null)
            {
                return HttpNotFound();
            }
            return View(job_WorkType);
        }

        // POST: WorkType/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name")] Job_WorkType job_WorkType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(job_WorkType).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(job_WorkType);
        }

        // GET: WorkType/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job_WorkType job_WorkType = await db.Job_WorkType.FindAsync(id);
            if (job_WorkType == null)
            {
                return HttpNotFound();
            }
            return View(job_WorkType);
        }

        // POST: WorkType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Job_WorkType job_WorkType = await db.Job_WorkType.FindAsync(id);
            db.Job_WorkType.Remove(job_WorkType);
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
