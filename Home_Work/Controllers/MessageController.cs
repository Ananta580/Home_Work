using Home_Work.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home_Work.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        public ActionResult Index(Contact_Messanger messanger)
        {
            return View(messanger);
        }
    }
}