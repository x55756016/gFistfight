using Project.BLL;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fistfight.Controllers
{
    public class FightController : Controller
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
                    V_xy_sp_userView up = new xy_sp_userspiritBLL().GetCurrentUserStatebyUserID(user.USERID);
                    if (up != null)
                    {
                        up.CurrentToken = tokenValue;
                        return View(up);
                    }
                }
            }
            return Redirect("/GameLogin");
        }
	}
}