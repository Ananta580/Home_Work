using Home_Work.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home_Work.Controllers
{
    public class ProfileController : Controller
    {
        HomeWorkDBEntities _db = new HomeWorkDBEntities();
        static int UID;
        // GET: Profile
        public ActionResult Index(string id)
        {
            UID= _db.Profile_User.Where(m => m.UserName == User.Identity.Name).FirstOrDefault().ID;
            return View(_db.Profile_User.Where(m=>m.UserName==id).FirstOrDefault());
        }

    }


}