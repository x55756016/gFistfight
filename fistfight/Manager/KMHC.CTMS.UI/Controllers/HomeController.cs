using AutoMapper;
using Project.BLL;
using Project.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.UI.Controllers
{
    public class HomeController :Controller
    {
        public ActionResult Index()
        {
            ViewBag.para = "";
            HttpCookie cookie = Request.Cookies["Token"];
            if (cookie != null)
            {
                string tokenValue = cookie.Value;
                if (!string.IsNullOrEmpty(tokenValue))
                {
                    V_tm_pm_userinfo user = new tm_pm_userinfoBLL().GetLoginInfo(tokenValue);
                    if (user != null)
                        return View();
                }
            }
            return Redirect("User/Login");
        }

        public ActionResult Login()
        {
            return View();
        }

    }
}
