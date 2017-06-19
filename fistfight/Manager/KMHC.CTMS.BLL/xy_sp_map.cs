/*
 * 描述:
 *  
 * 修订历史: 
 * 日期                    修改人              Email                   内容
 * 2017-06-15                                         创建 
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
    public class xy_sp_mapBLL
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Add(V_xy_sp_map model)
        {
             if (model == null)
                return string.Empty;
                
  			using(xy_sp_mapDAL dal = new xy_sp_mapDAL()){              
            xy_sp_map entity = ModelToEntity(model);
            entity.AddrID = string.IsNullOrEmpty(model.AddrID) ? Guid.NewGuid().ToString("N") : model.AddrID;

            return dal.Add(entity);
            }
        }
		
		/// <summary>
        /// 获取单条数据
        /// </summary>
        /// <returns></returns>
        public V_xy_sp_map Get(Expression<Func<xy_sp_map, bool>> predicate = null)
        {
        	using(xy_sp_mapDAL dal = new xy_sp_mapDAL()){        
	            xy_sp_map entity= dal.Get(predicate);
	            return EntityToModel(entity); 
            }
        }
		
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<V_xy_sp_map> Get()
        {
        	using(xy_sp_mapDAL dal = new xy_sp_mapDAL()){        
	            List<xy_sp_map> entitys = dal.Get().ToList();
	            List<V_xy_sp_map> list = new List<V_xy_sp_map>();
	            foreach (xy_sp_map item in entitys)
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
        public IEnumerable<V_xy_sp_map> GetList(PageInfo page)
        {
        	using(xy_sp_mapDAL dal = new xy_sp_mapDAL()){        
	            var list = dal.Get();
	
	            return list.Paging(ref page).Select(EntityToModel).ToList();
            }
        }
		
		/// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Edit(V_xy_sp_map model)
        {
            if (model == null) return false;
            using(xy_sp_mapDAL dal = new xy_sp_mapDAL()){        
	            xy_sp_map entitys = ModelToEntity(model);
	            
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
			using(xy_sp_mapDAL dal = new xy_sp_mapDAL()){        
           		return dal.Delete(id);
            }
        }
      
        /// <summary>
        /// Model转Entity
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private xy_sp_map ModelToEntity(V_xy_sp_map model)
        {
            if (model != null)
            {
                xy_sp_map entity = new xy_sp_map()
                {
                	                    	AddrID = model.AddrID,
                                        	AddrName = model.AddrName,
                                        	AddrDescript = model.AddrDescript,
                                        	AddrX = model.AddrX,
                                        	AddrY = model.AddrY,
                                        	FatherAddrID = model.FatherAddrID,
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
        private V_xy_sp_map  EntityToModel(xy_sp_map  entity)
        {
            if (entity != null)
            {
                V_xy_sp_map  model = new V_xy_sp_map ()
                {
                                       	AddrID = entity.AddrID,
                                        	AddrName = entity.AddrName,
                                        	AddrDescript = entity.AddrDescript,
                                        	AddrX = entity.AddrX,
                                        	AddrY = entity.AddrY,
                                        	FatherAddrID = entity.FatherAddrID,
                                    };

                return model;
            }

            return null;
        }

       
    }
}
