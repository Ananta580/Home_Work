using Home_Work.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home_Work.Controllers
{
    public class EducationController : Controller
    {
        HomeWorkDBEntities _db = new HomeWorkDBEntities();

        // GET: Work
        public ActionResult Index()
        {
            return PartialView(_db.Profile_Education.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Profile_Education pw)
        {
            pw.UserID = _db.Profile_User.Where(m => m.UserName == User.Identity.Name).FirstOrDefault().ID; 
            _db.Profile_Education.Add(pw);
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
        public ActionResult Edit(Profile_Education pw)
        {
            Profile_Education pwr = _db.Profile_Education.Where(m => m.ID == workID).FirstOrDefault();
            pwr.Level = pw.Level;
            pwr.PassOutDate = pw.PassOutDate;
            pwr.Affiliation = pw.Affiliation;
            pwr.SchoolName = pw.SchoolName;
            
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
            Profile_Education pwr = _db.Profile_Education.Where(m => m.ID == workID).FirstOrDefault();
            _db.Profile_Education.Remove(pwr);

            _db.SaveChanges();
            return RedirectToAction("Index", "Profile");
        }
    }
}