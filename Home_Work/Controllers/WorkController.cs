using Home_Work.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home_Work.Controllers
{
    
    public class WorkController : Controller
    {
        HomeWorkDBEntities _db = new HomeWorkDBEntities();

        // GET: Work
        public ActionResult Index()
        {
            return PartialView(_db.Profile_Work.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Profile_Work pw)
        {
            pw.UserID = _db.Profile_User.Where(m => m.UserName == User.Identity.Name).FirstOrDefault().ID; ;
            _db.Profile_Work.Add(pw);
            _db.SaveChanges();
            return RedirectToAction("Index","Profile");
        }
        static int workID;
        public ActionResult Edit(int id)
        {
            workID = id;
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Profile_Work pw)
        {
            Profile_Work pwr = _db.Profile_Work.Where(m => m.ID == workID).FirstOrDefault();
            pwr.Position = pw.Position;
            pwr.Profile_User = pw.Profile_User;
            pwr.Responsibility = pw.Responsibility;
            pwr.StartDate = pw.StartDate;
            pwr.CompanyName = pw.CompanyName;
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
            Profile_Work pwr = _db.Profile_Work.Where(m => m.ID == workID).FirstOrDefault();
            _db.Profile_Work.Remove(pwr);

            _db.SaveChanges();
            return RedirectToAction("Index", "Profile");
        }
    }
}