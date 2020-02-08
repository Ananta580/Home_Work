using Home_Work.Models;
using Home_Work.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home_Work.Controllers
{
    public class JobController : Controller
    {
        public HomeWorkDBEntities db = new HomeWorkDBEntities();
        public ActionResult Detail(int Id)
        {
            ViewBag.WorkType = db.Job_WorkType.ToList();
            ViewBag.SkillType = db.Job_SkillType.ToList();
            Job_Post job = db.Job_Post.Where(X => X.Id == Id).FirstOrDefault();
            return View(job);
        }
        [HttpPost]
        public ActionResult Detail(string proposal, int id=0 ,int userid=0)
        {
            Contact_Message messasge = new Contact_Message();
            messasge.Message = proposal;
            db.Contact_Message.Add(messasge);
            db.SaveChanges();
            var messId = db.Contact_Message.Where(x => x.Message == proposal).FirstOrDefault();
            Contact_Messanger messanger = new Contact_Messanger();
            messanger.MessageID = messId.ID;
            messanger.SenderID = db.Profile_User.Where(x => x.UserName == User.Identity.Name).FirstOrDefault().ID;
            messanger.RecieverID = id;
            messanger.Date = DateTime.Now;
            db.Contact_Messanger.Add(messanger);
            db.SaveChanges();
            Profile_WorkStatus stat = new Profile_WorkStatus();
            stat.Approved = "false";
            stat.JobId = id;
            stat.UserId = db.Profile_User.Where(x => x.UserName == User.Identity.Name).FirstOrDefault().ID;
            db.Profile_WorkStatus.Add(stat);
            db.SaveChanges();
            return RedirectToAction("Index", "Message",messanger);
        }
        [Authorize]
        [HttpGet]
        public ActionResult PostJob()
        {
            ViewBag.WorkingTypes = db.Job_WorkType.ToList();
            ViewBag.SkillTypes = db.Job_SkillType.ToList();
            return View();
        }
        [HttpPost]
        [Authorize]
        public ActionResult PostJob(Job_Post job)
        {
            ViewBag.WorkingTypes = db.Job_WorkType.ToList();
            ViewBag.SkillTypes = db.Job_SkillType.ToList();
            job.UserId = db.Profile_User.Where(x => x.UserName == User.Identity.Name).FirstOrDefault().ID;
            db.Job_Post.Add(job);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult JobList()
        {
            ViewBag.WorkType = db.Job_WorkType.ToList();
            ViewBag.SkillType = db.Job_SkillType.ToList();
            return View(db.Job_Post.ToList());
        }
    }
}