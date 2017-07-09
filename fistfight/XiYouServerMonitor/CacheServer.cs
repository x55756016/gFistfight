using Project.BLL;
using Project.Common.Cached;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XiYouServerMonitor
{
    public static class CacheServer
    {
        private static ICached _cached = DistributedCachedProvider.Instance;

        public static void cacheuserView(string tokenValue,V_xy_sp_userView userView)
        {
            _cached.Set(tokenValue, userView);
        }

        public static V_xy_sp_userView GetUserViewFromCache(string tokenValue)
        {
            V_tm_pm_userinfo userInfo = _cached.Get(tokenValue) as V_tm_pm_userinfo;
            if (userInfo == null)
            {
                userInfo = new tm_pm_userinfoBLL().GetLoginInfo(tokenValue);
            }

            V_xy_sp_userView userView = (V_xy_sp_userView)_cached.Get(tokenValue + "V_xy_sp_userView");
            if(userView==null)
            {
                userView = new xy_sp_userspiritBLL().GetCurrentUserStatebyUserID(userInfo.USERID);
                cacheuserView(tokenValue + "V_xy_sp_userView", userView);
            }
            return userView;
        }

        public static void UpdatetUserViewCache(string tokenValue,V_xy_sp_userView userView)
        {
            _cached.Remove(tokenValue + "V_xy_sp_userView");
            cacheuserView(tokenValue + "V_xy_sp_userView", userView);
        }

    }
}
