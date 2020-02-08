using Home_Work.Models;
using Home_Work.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home_Work.Controllers
{
    public class HomeController : Controller
    {
        public HomeWorkDBEntities db = new HomeWorkDBEntities();
        public ActionResult Index()
        {
            ViewBag.WorkType = db.Job_WorkType.ToList();
            ViewBag.SkillType = db.Job_SkillType.ToList();
            return View(db.Job_Post.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}