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
    public class xy_sp_taskspiritBLL
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Add(V_xy_sp_taskspirit model)
        {
             if (model == null)
                return string.Empty;
                
  			using(xy_sp_taskspiritDAL dal = new xy_sp_taskspiritDAL()){              
            xy_sp_taskspirit entity = ModelToEntity(model);
            entity.UserSpiritID = string.IsNullOrEmpty(model.UserSpiritID) ? Guid.NewGuid().ToString("N") : model.UserSpiritID;

            return dal.Add(entity);
            }
        }
		
		/// <summary>
        /// 获取单条数据
        /// </summary>
        /// <returns></returns>
        public V_xy_sp_taskspirit Get(Expression<Func<xy_sp_taskspirit, bool>> predicate = null)
        {
        	using(xy_sp_taskspiritDAL dal = new xy_sp_taskspiritDAL()){        
	            xy_sp_taskspirit entity= dal.Get(predicate);
	            return EntityToModel(entity); 
            }
        }
		
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<V_xy_sp_taskspirit> Get()
        {
        	using(xy_sp_taskspiritDAL dal = new xy_sp_taskspiritDAL()){        
	            List<xy_sp_taskspirit> entitys = dal.Get().ToList();
	            List<V_xy_sp_taskspirit> list = new List<V_xy_sp_taskspirit>();
	            foreach (xy_sp_taskspirit item in entitys)
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
        public IEnumerable<V_xy_sp_taskspirit> GetList(PageInfo page)
        {
        	using(xy_sp_taskspiritDAL dal = new xy_sp_taskspiritDAL()){        
	            var list = dal.Get();
	
	            return list.Paging(ref page).Select(EntityToModel).ToList();
            }
        }
		
		/// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Edit(V_xy_sp_taskspirit model)
        {
            if (model == null) return false;
            using(xy_sp_taskspiritDAL dal = new xy_sp_taskspiritDAL()){        
	            xy_sp_taskspirit entitys = ModelToEntity(model);
	            
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
			using(xy_sp_taskspiritDAL dal = new xy_sp_taskspiritDAL()){        
           		return dal.Delete(id);
            }
        }
      
        /// <summary>
        /// Model转Entity
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private xy_sp_taskspirit ModelToEntity(V_xy_sp_taskspirit model)
        {
            if (model != null)
            {
                xy_sp_taskspirit entity = new xy_sp_taskspirit()
                {
                	                    	UserSpiritID = model.UserSpiritID,
                                        	UserId = model.UserId,
                                        	SpiritID = model.SpiritID,
                                        	isBoos = model.isBoos,
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
        private V_xy_sp_taskspirit  EntityToModel(xy_sp_taskspirit  entity)
        {
            if (entity != null)
            {
                V_xy_sp_taskspirit  model = new V_xy_sp_taskspirit ()
                {
                                       	UserSpiritID = entity.UserSpiritID,
                                        	UserId = entity.UserId,
                                        	SpiritID = entity.SpiritID,
                                        	isBoos = entity.isBoos,
                                    };

                return model;
            }

            return null;
        }

       
    }
}
