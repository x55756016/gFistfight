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
    public class xy_sp_taskoptionBLL
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Add(V_xy_sp_taskoption model)
        {
             if (model == null)
                return string.Empty;
                
  			using(xy_sp_taskoptionDAL dal = new xy_sp_taskoptionDAL()){              
            xy_sp_taskoption entity = ModelToEntity(model);
            entity.OptionID = string.IsNullOrEmpty(model.OptionID) ? Guid.NewGuid().ToString("N") : model.OptionID;

            return dal.Add(entity);
            }
        }
		
		/// <summary>
        /// 获取单条数据
        /// </summary>
        /// <returns></returns>
        public V_xy_sp_taskoption Get(Expression<Func<xy_sp_taskoption, bool>> predicate = null)
        {
        	using(xy_sp_taskoptionDAL dal = new xy_sp_taskoptionDAL()){        
	            xy_sp_taskoption entity= dal.Get(predicate);
	            return EntityToModel(entity); 
            }
        }
		
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<V_xy_sp_taskoption> Get()
        {
        	using(xy_sp_taskoptionDAL dal = new xy_sp_taskoptionDAL()){        
	            List<xy_sp_taskoption> entitys = dal.Get().ToList();
	            List<V_xy_sp_taskoption> list = new List<V_xy_sp_taskoption>();
	            foreach (xy_sp_taskoption item in entitys)
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
        public IEnumerable<V_xy_sp_taskoption> GetList(PageInfo page)
        {
        	using(xy_sp_taskoptionDAL dal = new xy_sp_taskoptionDAL()){        
	            var list = dal.Get();
	
	            return list.Paging(ref page).Select(EntityToModel).ToList();
            }
        }
		
		/// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Edit(V_xy_sp_taskoption model)
        {
            if (model == null) return false;
            using(xy_sp_taskoptionDAL dal = new xy_sp_taskoptionDAL()){        
	            xy_sp_taskoption entitys = ModelToEntity(model);
	            
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
			using(xy_sp_taskoptionDAL dal = new xy_sp_taskoptionDAL()){        
           		return dal.Delete(id);
            }
        }
      
        /// <summary>
        /// Model转Entity
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private xy_sp_taskoption ModelToEntity(V_xy_sp_taskoption model)
        {
            if (model != null)
            {
                xy_sp_taskoption entity = new xy_sp_taskoption()
                {
                	                    	OptionID = model.OptionID,
                                        	OptionName = model.OptionName,
                                        	OptionDesc = model.OptionDesc,
                                        	IsCorrect = model.IsCorrect,
                                        	NextTaskID = model.NextTaskID,
                                        	PreviousTaskID = model.PreviousTaskID,
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
        private V_xy_sp_taskoption  EntityToModel(xy_sp_taskoption  entity)
        {
            if (entity != null)
            {
                V_xy_sp_taskoption  model = new V_xy_sp_taskoption ()
                {
                                       	OptionID = entity.OptionID,
                                        	OptionName = entity.OptionName,
                                        	OptionDesc = entity.OptionDesc,
                                        	IsCorrect = entity.IsCorrect,
                                        	NextTaskID = entity.NextTaskID,
                                        	PreviousTaskID = entity.PreviousTaskID,
                                    };

                return model;
            }

            return null;
        }

       
    }
}
