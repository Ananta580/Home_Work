using Home_Work.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home_Work.Controllers
{
    public class ImageController : Controller
    {
        HomeWorkDBEntities _db = new HomeWorkDBEntities();
        static int portfolioid;
        public ActionResult Index(int id)
        {
            portfolioid = id;
            return PartialView(_db.Portfolio_Image.Where(m=>m.PortfolioID==portfolioid).ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Portfolio_Image tb)
        {


            HttpPostedFileBase fup = Request.Files["Photo"];
            if (fup != null)
            {
                tb.Photo = fup.FileName;
                tb.PortfolioID = portfolioid;
                tb.UserID = _db.Profile_User.Where(m => m.UserName == User.Identity.Name).FirstOrDefault().ID;
                fup.SaveAs(Server.MapPath("~/Images/Portfolio/" + fup.FileName));
            }
            _db.Portfolio_Image.Add(tb);
            if (_db.SaveChanges() > 0)
            {
                return RedirectToAction("Index","Profile");
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            Portfolio_Image tb = _db.Portfolio_Image.Where(u => u.ID == id).FirstOrDefault();
            return View(tb);
        }
        [HttpPost]
        public ActionResult Edit(Portfolio_Image bd)
        {
            Portfolio_Image tb = _db.Portfolio_Image.Where(u => u.ID == bd.ID).FirstOrDefault();

            tb.ImageCaption = bd.ImageCaption;
            HttpPostedFileBase fup = Request.Files["Photo"];
            if (fup != null)
            {
                if (fup.FileName != "")
                {
                    System.IO.File.Delete(Server.MapPath("~/Images/Portfolio/" + bd.Photo));

                    tb.Photo = fup.FileName;
                    fup.SaveAs(Server.MapPath("~/Images/Portfolio/" + fup.FileName));


                }
                else
                {
                    tb.Photo = bd.Photo;
                }
            }
            if (_db.SaveChanges() > 0)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
        static int workID;
        public ActionResult Delete(int id)
        {
            workID = id;
            return View();
        }
        [HttpPost]
        public ActionResult Delete()
        {
            Portfolio_Image pwr = _db.Portfolio_Image.Where(m => m.ID == workID).FirstOrDefault();
            _db.Portfolio_Image.Remove(pwr);

            _db.SaveChanges();
            return RedirectToAction("Index", "Profile");
        }
    }
}