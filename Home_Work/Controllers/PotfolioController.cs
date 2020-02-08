using Home_Work.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home_Work.Controllers
{
    public class PotfolioController : Controller
    {
        HomeWorkDBEntities _db = new HomeWorkDBEntities();

        // GET: Work
        public ActionResult Index()
        {
            return PartialView(_db.Profile_Portfolio.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Profile_Portfolio pw)
        {
            pw.UserID = _db.Profile_User.Where(m => m.UserName == User.Identity.Name).FirstOrDefault().ID; ;
            _db.Profile_Portfolio.Add(pw);
            _db.SaveChanges();
            return RedirectToAction("Index", "Profile");
        }
        static int workID;
        public ActionResult Edit(int id)
        {
            workID = id;
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Profile_Portfolio pw)
        {
            Profile_Portfolio pwr = _db.Profile_Portfolio.Where(m => m.ID == workID).FirstOrDefault();
            pwr.ProjectDescription = pw.ProjectDescription;
            pwr.Project_Name = pw.Project_Name;
            pwr.ToolsUsed = pw.ToolsUsed;
            pwr.Date = pw.Date;

            _db.SaveChanges();
            return RedirectToAction("Index", "Profile");
        }
        public ActionResult Delete(int id)
        {
            workID = id;
            return View();
        }
        [HttpPost]
        public ActionResult Delete()
        {
            Profile_Portfolio pwr = _db.Profile_Portfolio.Where(m => m.ID == workID).FirstOrDefault();
            _db.Profile_Portfolio.Remove(pwr);

            _db.SaveChanges();
            return RedirectToAction("Index", "Profile");
        }
    }
}