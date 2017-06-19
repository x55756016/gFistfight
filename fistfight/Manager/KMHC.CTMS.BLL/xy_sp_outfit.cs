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
    public class xy_sp_outfitBLL
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Add(V_xy_sp_outfit model)
        {
             if (model == null)
                return string.Empty;
                
  			using(xy_sp_outfitDAL dal = new xy_sp_outfitDAL()){              
            xy_sp_outfit entity = ModelToEntity(model);
            entity.OutfitID = string.IsNullOrEmpty(model.OutfitID) ? Guid.NewGuid().ToString("N") : model.OutfitID;

            return dal.Add(entity);
            }
        }
		
		/// <summary>
        /// 获取单条数据
        /// </summary>
        /// <returns></returns>
        public V_xy_sp_outfit Get(Expression<Func<xy_sp_outfit, bool>> predicate = null)
        {
        	using(xy_sp_outfitDAL dal = new xy_sp_outfitDAL()){        
	            xy_sp_outfit entity= dal.Get(predicate);
	            return EntityToModel(entity); 
            }
        }
		
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<V_xy_sp_outfit> Get()
        {
        	using(xy_sp_outfitDAL dal = new xy_sp_outfitDAL()){        
	            List<xy_sp_outfit> entitys = dal.Get().ToList();
	            List<V_xy_sp_outfit> list = new List<V_xy_sp_outfit>();
	            foreach (xy_sp_outfit item in entitys)
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
        public IEnumerable<V_xy_sp_outfit> GetList(PageInfo page)
        {
        	using(xy_sp_outfitDAL dal = new xy_sp_outfitDAL()){        
	            var list = dal.Get();
	
	            return list.Paging(ref page).Select(EntityToModel).ToList();
            }
        }
		
		/// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Edit(V_xy_sp_outfit model)
        {
            if (model == null) return false;
            using(xy_sp_outfitDAL dal = new xy_sp_outfitDAL()){        
	            xy_sp_outfit entitys = ModelToEntity(model);
	            
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
			using(xy_sp_outfitDAL dal = new xy_sp_outfitDAL()){        
           		return dal.Delete(id);
            }
        }
      
        /// <summary>
        /// Model转Entity
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private xy_sp_outfit ModelToEntity(V_xy_sp_outfit model)
        {
            if (model != null)
            {
                xy_sp_outfit entity = new xy_sp_outfit()
                {
                	                    	OutfitID = model.OutfitID,
                                        	EquipmentName = model.EquipmentName,
                                        	NeedLevel = model.NeedLevel,
                                        	Price = model.Price,
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
        private V_xy_sp_outfit  EntityToModel(xy_sp_outfit  entity)
        {
            if (entity != null)
            {
                V_xy_sp_outfit  model = new V_xy_sp_outfit ()
                {
                                       	OutfitID = entity.OutfitID,
                                        	EquipmentName = entity.EquipmentName,
                                        	NeedLevel = entity.NeedLevel,
                                        	Price = entity.Price,
                                    };

                return model;
            }

            return null;
        }

       
    }
}
