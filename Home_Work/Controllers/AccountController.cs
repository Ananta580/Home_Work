using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Home_Work.Models;
using Home_Work.Models.ViewModels;

namespace Home_Work.Controllers
{
    public class AccountController : Controller
    {
        public  Home_WorkDBEntities db = new Home_WorkDBEntities();

        public ActionResult Login()
        {
            return View("Login");
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel l, string returnUrl = "")
        {
            var users = db.Profile_User.Where(x => x.Email == l.UserName || x.UserName == l.UserName && x.Password == l.Password).FirstOrDefault();
            if (users != null)
            {
                FormsAuthentication.SetAuthCookie(users.UserName, l.RememberMe);
                if (Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "");
                }


            }
            else
            {
                ModelState.AddModelError("", "Invalid User");
            }
            return View("Login");
        }
        [Authorize]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profile_User profile_User = db.Profile_User.Find(id);
            if (profile_User == null)
            {
                return HttpNotFound();
            }
            return View(profile_User);
        }

        // GET: Account/Create
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,UserName,Password,LastLoginDate,FirstName,MiddleName,LastName,Gender,Nationality,Address,Email,Phone,CountryCode")] Profile_User profile_User)
        {
            if (ModelState.IsValid)
            {
                db.Profile_User.Add(profile_User);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(profile_User);
        }

        // GET: Account/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profile_User profile_User = db.Profile_User.Find(id);
            if (profile_User == null)
            {
                return HttpNotFound();
            }
            return View(profile_User);
        }

        // POST: Account/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,UserName,Password,LastLoginDate,FirstName,MiddleName,LastName,Gender,Nationality,Address,Email,Phone,CountryCode")] Profile_User profile_User)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profile_User).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(profile_User);
        }

        // GET: Account/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profile_User profile_User = db.Profile_User.Find(id);
            if (profile_User == null)
            {
                return HttpNotFound();
            }
            return View(profile_User);
        }

        // POST: Account/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Profile_User profile_User = db.Profile_User.Find(id);
            db.Profile_User.Remove(profile_User);
            db.SaveChanges();
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
