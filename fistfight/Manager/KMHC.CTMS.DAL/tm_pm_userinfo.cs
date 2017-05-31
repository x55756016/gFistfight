/*
 * 描述:
 *  
 * 修订历史: 
 * 日期                    修改人              Email                   内容
 * 2015-12-02                                         创建 
 *  
 */

using Project.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Project.DAL
{
    public class tm_pm_userinfoDAL : BaseDAL<tm_pm_userinfo>
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string Add(tm_pm_userinfo entity)
        {
            base.Insert(entity);
            return entity.USERID;
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Edit(tm_pm_userinfo entity)
        {
            return base.Update(entity);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            return base.DeleteById(id);
        }

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public IQueryable<tm_pm_userinfo> Get()
        {
            return base.FindAll();
        }

        /// <summary>
        /// 单条数据
        /// </summary>
        /// <returns></returns>
        public tm_pm_userinfo Get(Expression<Func<tm_pm_userinfo, bool>> predicate = null)
        {
            return base.FindOne(predicate);
        }

        public tm_pm_userinfo GetUserInfoByLoginName(string loginName)
        {
            tm_pm_userinfo userInfo = base.FindOne(p => p.LOGINNAME == loginName);
            return userInfo;
        }

        public bool AddUserInfo(tm_pm_userinfo user)
        {
            bool result = base.Insert(user);
            return result;
        }

        public tm_pm_userinfo GetUserInfoByEmail(string email)
        {
            tm_pm_userinfo userInfo = base.FindOne(p => p.EMAIL == email);
            return userInfo;
        }

        public tm_pm_userinfo GetUserInfoByMobilePhone(string mobilePhone)
        {
            tm_pm_userinfo userInfo = base.FindOne(p => p.MOBILEPHONE == mobilePhone);
            return userInfo;
        }


        public tm_pm_userinfo GetUserInfoByID(string id)
        {
            tm_pm_userinfo userInfo = base.FindOne(p => p.USERID == id);
            return userInfo;
        }


        public bool UpdateUserInfo(tm_pm_userinfo user)
        {
            return base.Update(user);
        }
    }
}