using Home_Work.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home_Work.Controllers
{
    public class TrainingController : Controller
    {
        HomeWorkDBEntities _db = new HomeWorkDBEntities();

        // GET: Work
        public ActionResult Index()
        {
            return PartialView(_db.Profile_Training.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Profile_Training pw)
        {
            pw.UserID = _db.Profile_User.Where(m => m.UserName == User.Identity.Name).FirstOrDefault().ID; ;
            _db.Profile_Training.Add(pw);
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
        public ActionResult Edit(Profile_Training pw)
        {
            Profile_Training pwr = _db.Profile_Training.Where(m => m.ID == workID).FirstOrDefault();
            pwr.CertificationName = pw.CertificationName;
            pwr.InstituteName = pw.InstituteName;
            pwr.Skills = pw.Skills;
            pwr.ComletedDate = pw.ComletedDate;

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
            Profile_Training pwr = _db.Profile_Training.Where(m => m.ID == workID).FirstOrDefault();
            _db.Profile_Training.Remove(pwr);

            _db.SaveChanges();
            return RedirectToAction("Index", "Profile");
        }
    }
}