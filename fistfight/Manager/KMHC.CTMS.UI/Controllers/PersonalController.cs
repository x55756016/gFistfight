using Project.BLL;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fistfight.Controllers
{
    public class PersonalController : Controller
    {
        //
        // GET: /Fight/
        public ActionResult Index()
        {
            HttpCookie cookie = Request.Cookies["Token"];
            if (cookie != null)
            {
                string tokenValue = cookie.Value;
                if (!string.IsNullOrEmpty(tokenValue))
                {
                    V_tm_pm_userinfo user = new tm_pm_userinfoBLL().GetLoginInfo(tokenValue);
                    V_xy_sp_userspirit up = new xy_sp_userspiritBLL().GetbyUserID(user.USERID).UserSpirit;
                    if (up != null)
                        return View(up);
                }
            }
            return Redirect("/GameLogin");
        }
	}
}