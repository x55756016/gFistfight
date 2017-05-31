/*
 * 描述:
 *  
 * 修订历史: 
 * 日期                    修改人              Email                   内容
 * 2015-12-02                                         创建 
 *  
 */

using Project.Common.Cached;
using Project.Common.Helper;
using Project.DAL;
using Project.DAL.Database;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Project.BLL
{
    public class tm_pm_userinfoBLL
    {
        protected static tm_pm_userinfoDAL dal = new tm_pm_userinfoDAL();

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Add(V_tm_pm_userinfo model)
        {
            if (model == null)
                return string.Empty;
            tm_pm_userinfo entity = ModelToEntity(model);
            entity.USERID = string.IsNullOrEmpty(model.USERID) ? Guid.NewGuid().ToString("N") : model.USERID;

            return dal.Add(entity);
        }

        /// <summary>
        /// 获取单条数据
        /// </summary>
        /// <returns></returns>
        public V_tm_pm_userinfo Get(Expression<Func<tm_pm_userinfo, bool>> predicate = null)
        {
            tm_pm_userinfo entity = dal.Get(predicate);
            return EntityToModel(entity);
        }

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<V_tm_pm_userinfo> Get()
        {
            List<tm_pm_userinfo> entitys = dal.Get().ToList();
            List<V_tm_pm_userinfo> list = new List<V_tm_pm_userinfo>();
            foreach (tm_pm_userinfo item in entitys)
            {
                list.Add(EntityToModel(item));
            }
            return list;
        }

        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public IEnumerable<V_tm_pm_userinfo> GetList(PageInfo page)
        {
            var list = dal.Get();

            return list.Paging(ref page).Select(EntityToModel).ToList();
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Edit(V_tm_pm_userinfo model)
        {
            if (model == null) return false;
            tm_pm_userinfo entitys = ModelToEntity(model);

            return dal.Edit(entitys);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) return false;

            return dal.Delete(id);
        }

        /// <summary>
        /// Model转Entity
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private tm_pm_userinfo ModelToEntity(V_tm_pm_userinfo model)
        {
            if (model != null)
            {
                tm_pm_userinfo entity = new tm_pm_userinfo()
                {
                    USERID = model.USERID,
                    OWNERID = model.OWNERID,
                    ISDELETED = model.ISDELETED,
                    CREATEUSERNAME = model.CREATEUSERNAME,
                    EDITUSERNAME = model.EDITUSERNAME,
                    OWNERNAME = model.OWNERNAME,
                    USERTYPE = model.USERTYPE,
                    LOGINNAME = model.LOGINNAME,
                    LOGINPWD = model.LOGINPWD,
                    MOBILEPHONE = model.MOBILEPHONE,
                    EMAIL = model.EMAIL,
                    CREATEUSERID = model.CREATEUSERID,
                    CREATEDATETIME = model.CREATEDATETIME,
                    EDITUSERID = model.EDITUSERID,
                    EDITDATETIME = model.EDITDATETIME,
                };

                return entity;
            }
            return null;
        }

        /// <summary>
        /// Entity转Model
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        private V_tm_pm_userinfo EntityToModel(tm_pm_userinfo entity)
        {
            if (entity != null)
            {
                V_tm_pm_userinfo model = new V_tm_pm_userinfo()
                {
                    USERID = entity.USERID,
                    OWNERID = entity.OWNERID,
                    ISDELETED = entity.ISDELETED,
                    CREATEUSERNAME = entity.CREATEUSERNAME,
                    EDITUSERNAME = entity.EDITUSERNAME,
                    OWNERNAME = entity.OWNERNAME,
                    USERTYPE = entity.USERTYPE,
                    LOGINNAME = entity.LOGINNAME,
                    LOGINPWD = entity.LOGINPWD,
                    MOBILEPHONE = entity.MOBILEPHONE,
                    EMAIL = entity.EMAIL,
                    CREATEUSERID = entity.CREATEUSERID,
                    CREATEDATETIME = entity.CREATEDATETIME,
                    EDITUSERID = entity.EDITUSERID,
                    EDITDATETIME = entity.EDITDATETIME,
                };

                return model;
            }

            return null;
        }


        private ICached _cached = new LocalCached();

        /// <summary>
        /// 缓存时间
        /// </summary>
        private int CacheTime
        {
            get
            {
                return ConfigurationManager.AppSettings["CacheTime"].ToInt(30);
            }
        }

        /// <summary>
        /// 缓存字符串
        /// </summary>
        private string CacheString
        {
            get
            {
                return ConfigurationManager.AppSettings["CacheString"];
            }
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="loginName">登录名</param>
        /// <param name="loginPwd">登录密码</param>
        /// <returns></returns>
        public V_tm_pm_userinfo Login(string loginName, string loginPwd)
        {
            tm_pm_userinfo userInfo = dal.GetUserInfoByLoginName(loginName);
            if (userInfo == null)
                return EntityToModel(userInfo);

            loginPwd = loginPwd.ToMd5();
            if (!userInfo.LOGINPWD.Equals(loginPwd))
                return null;
            return EntityToModel(userInfo);
        }

        /// <summary>
        /// 通过id获取用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public V_tm_pm_userinfo GetUserInfoByID(string id)
        {
            tm_pm_userinfo userInfo = dal.GetUserInfoByID(id);
            return EntityToModel(userInfo);
        }

        /// <summary>
        /// 根据登录名获取用户信息
        /// </summary>
        /// <param name="loginName">登录名</param>
        /// <returns></returns>
        public V_tm_pm_userinfo GetUserByLoginName(string loginName)
        {
            tm_pm_userinfo userInfo = dal.GetUserInfoByLoginName(loginName);
            return EntityToModel(userInfo);
        }

        /// <summary>
        /// 通过邮箱获取用户信息
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public V_tm_pm_userinfo GetUserByEmail(string email)
        {
            tm_pm_userinfo userInfo = dal.GetUserInfoByEmail(email);
            return EntityToModel(userInfo);
        }

        /// <summary>
        /// 通过手机获取用户信息
        /// </summary>
        /// <param name="mobilePhone"></param>
        /// <returns></returns>
        public V_tm_pm_userinfo GetUserByMobilePhone(string mobilePhone)
        {
            tm_pm_userinfo userInfo = dal.GetUserInfoByMobilePhone(mobilePhone);
            return EntityToModel(userInfo);
        }

        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool AddUserInfo(V_tm_pm_userinfo user)
        {
            if (user == null) return false;
            tm_pm_userinfo userinfo = ModelToEntity(user);

            return dal.AddUserInfo(userinfo);
        }

        /// <summary>
        /// 通过id更新用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool UpdateUserInfo(V_tm_pm_userinfo user)
        {
            if (user == null) return false;
            tm_pm_userinfo userinfo = ModelToEntity(user);

            return dal.UpdateUserInfo(userinfo);
        }

        /// <summary>
        /// 缓存信息
        /// </summary>
        /// <param name="tokenValue"></param>
        /// <param name="userInfo"></param>
        public void CacheInfo(string tokenValue, object userInfo)
        {
            _cached.Set(tokenValue, userInfo, CacheTime);
        }

        /// <summary>
        /// 根据令牌获取用户登录信息(没有则返回null)
        /// </summary>
        /// <param name="tokenValue">令牌</param>
        /// <returns></returns>
        public V_tm_pm_userinfo GetLoginInfo(string tokenValue)
        {
            if (string.IsNullOrEmpty(tokenValue))
                return null;
            V_tm_pm_userinfo userInfo = _cached.Get(tokenValue) as V_tm_pm_userinfo;
            return userInfo;
        }

        /// <summary>
        /// 注销
        /// </summary>
        /// <returns></returns>
        public bool Logout()
        {
            try
            {
                HttpCookie cookie = HttpContext.Current.Request.Cookies["Token"];
                if (cookie == null)
                    return true;
                _cached.Remove(cookie.Value + CacheString);
                _cached.Remove(cookie.Value);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 判断当前是否已登录
        /// </summary>
        /// <returns></returns>
        public bool IsLogin()
        {
            bool isLogin = false;
            HttpCookie cookie = HttpContext.Current.Request.Cookies["Token"];
            if (cookie != null)
            {
                V_tm_pm_userinfo user = GetLoginInfo(cookie.Value);
                if (user != null)
                {
                    isLogin = true;
                }
            }
            return isLogin;
        }

        public V_tm_pm_userinfo GetCurrentUser()
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies["Token"];
            if (cookie == null || string.IsNullOrEmpty(cookie.Value))
            {
                return null;
            }
            return GetLoginInfo(cookie.Value);
        }
    }
}
