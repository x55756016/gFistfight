/*
 * 描述:
 *  
 * 修订历史: 
 * 日期                    修改人              Email                   内容
 * 2017-05-31                                         创建 
 *  
 */
 
using Project.Common.Helper;
using Project.DAL;
using Project.DAL.Database;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Project.BLL
{
    public class xy_sp_userinfoBLL
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Add(V_xy_sp_userinfo model)
        {
             if (model == null)
                return string.Empty;
                
  			using(xy_sp_userinfoDAL dal = new xy_sp_userinfoDAL()){              
            xy_sp_userinfo entity = ModelToEntity(model);
            entity.UserId = string.IsNullOrEmpty(model.UserId) ? Guid.NewGuid().ToString("N") : model.UserId;

            return dal.Add(entity);
            }
        }
		
		/// <summary>
        /// 获取单条数据
        /// </summary>
        /// <returns></returns>
        public V_xy_sp_userinfo Get(Expression<Func<xy_sp_userinfo, bool>> predicate = null)
        {
        	using(xy_sp_userinfoDAL dal = new xy_sp_userinfoDAL()){        
	            xy_sp_userinfo entity= dal.Get(predicate);
	            return EntityToModel(entity); 
            }
        }
		
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<V_xy_sp_userinfo> Get()
        {
        	using(xy_sp_userinfoDAL dal = new xy_sp_userinfoDAL()){        
	            List<xy_sp_userinfo> entitys = dal.Get().ToList();
	            List<V_xy_sp_userinfo> list = new List<V_xy_sp_userinfo>();
	            foreach (xy_sp_userinfo item in entitys)
	            {
	                list.Add(EntityToModel(item));
	            }
	            return list;
            }
        }
        
        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public IEnumerable<V_xy_sp_userinfo> GetList(PageInfo page)
        {
        	using(xy_sp_userinfoDAL dal = new xy_sp_userinfoDAL()){        
	            var list = dal.Get();
	
	            return list.Paging(ref page).Select(EntityToModel).ToList();
            }
        }
		
		/// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Edit(V_xy_sp_userinfo model)
        {
            if (model == null) return false;
            using(xy_sp_userinfoDAL dal = new xy_sp_userinfoDAL()){        
	            xy_sp_userinfo entitys = ModelToEntity(model);
	            
	            return dal.Edit(entitys);
            }
        }
        
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) return false;
			using(xy_sp_userinfoDAL dal = new xy_sp_userinfoDAL()){        
           		return dal.Delete(id);
            }
        }
      
        /// <summary>
        /// Model转Entity
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private xy_sp_userinfo ModelToEntity(V_xy_sp_userinfo model)
        {
            if (model != null)
            {
                xy_sp_userinfo entity = new xy_sp_userinfo()
                {
                	                    	UserId = model.UserId,
                                        	LoginName = model.LoginName,
                                        	UserName = model.UserName,
                                        	LoginPwd = model.LoginPwd,
                                        	MobilePhone = model.MobilePhone,
                                        	Email = model.Email,
                                        	UserType = model.UserType,
                                        	UserStatus = model.UserStatus,
                                        	MemberID = model.MemberID,
                                        	MemberStartDate = model.MemberStartDate,
                                        	MemberEndDate = model.MemberEndDate,
                                        	Account = model.Account,
                                        	ICONPATH = model.ICONPATH,
                                        	CreateUserName = model.CreateUserName,
                                        	EditUserName = model.EditUserName,
                                        	OwnerName = model.OwnerName,
                                        	CreateUserId = model.CreateUserId,
                                        	CreateDateTime = model.CreateDateTime,
                                        	EditUserId = model.EditUserId,
                                        	EditDateTime = model.EditDateTime,
                                        	IsDeleted = model.IsDeleted,
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
        private V_xy_sp_userinfo  EntityToModel(xy_sp_userinfo  entity)
        {
            if (entity != null)
            {
                V_xy_sp_userinfo  model = new V_xy_sp_userinfo ()
                {
                                       	UserId = entity.UserId,
                                        	LoginName = entity.LoginName,
                                        	UserName = entity.UserName,
                                        	LoginPwd = entity.LoginPwd,
                                        	MobilePhone = entity.MobilePhone,
                                        	Email = entity.Email,
                                        	UserType = entity.UserType,
                                        	UserStatus = entity.UserStatus,
                                        	MemberID = entity.MemberID,
                                        	MemberStartDate = entity.MemberStartDate,
                                        	MemberEndDate = entity.MemberEndDate,
                                        	Account = entity.Account,
                                        	ICONPATH = entity.ICONPATH,
                                        	CreateUserName = entity.CreateUserName,
                                        	EditUserName = entity.EditUserName,
                                        	OwnerName = entity.OwnerName,
                                        	CreateUserId = entity.CreateUserId,
                                        	CreateDateTime = entity.CreateDateTime,
                                        	EditUserId = entity.EditUserId,
                                        	EditDateTime = entity.EditDateTime,
                                        	IsDeleted = entity.IsDeleted,
                                    };

                return model;
            }

            return null;
        }

       
    }
}
