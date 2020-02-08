using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home_Work.Models.ViewModels
{
    public class LoginViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Boolean RememberMe { get; set;}
    }
}