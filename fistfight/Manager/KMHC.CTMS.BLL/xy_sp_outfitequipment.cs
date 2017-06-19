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
    public class xy_sp_outfitequipmentBLL
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Add(V_xy_sp_outfitequipment model)
        {
             if (model == null)
                return string.Empty;
                
  			using(xy_sp_outfitequipmentDAL dal = new xy_sp_outfitequipmentDAL()){              
            xy_sp_outfitequipment entity = ModelToEntity(model);
            entity.OutfitEquipmentID = string.IsNullOrEmpty(model.OutfitEquipmentID) ? Guid.NewGuid().ToString("N") : model.OutfitEquipmentID;

            return dal.Add(entity);
            }
        }
		
		/// <summary>
        /// 获取单条数据
        /// </summary>
        /// <returns></returns>
        public V_xy_sp_outfitequipment Get(Expression<Func<xy_sp_outfitequipment, bool>> predicate = null)
        {
        	using(xy_sp_outfitequipmentDAL dal = new xy_sp_outfitequipmentDAL()){        
	            xy_sp_outfitequipment entity= dal.Get(predicate);
	            return EntityToModel(entity); 
            }
        }
		
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<V_xy_sp_outfitequipment> Get()
        {
        	using(xy_sp_outfitequipmentDAL dal = new xy_sp_outfitequipmentDAL()){        
	            List<xy_sp_outfitequipment> entitys = dal.Get().ToList();
	            List<V_xy_sp_outfitequipment> list = new List<V_xy_sp_outfitequipment>();
	            foreach (xy_sp_outfitequipment item in entitys)
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
        public IEnumerable<V_xy_sp_outfitequipment> GetList(PageInfo page)
        {
        	using(xy_sp_outfitequipmentDAL dal = new xy_sp_outfitequipmentDAL()){        
	            var list = dal.Get();
	
	            return list.Paging(ref page).Select(EntityToModel).ToList();
            }
        }
		
		/// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Edit(V_xy_sp_outfitequipment model)
        {
            if (model == null) return false;
            using(xy_sp_outfitequipmentDAL dal = new xy_sp_outfitequipmentDAL()){        
	            xy_sp_outfitequipment entitys = ModelToEntity(model);
	            
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
			using(xy_sp_outfitequipmentDAL dal = new xy_sp_outfitequipmentDAL()){        
           		return dal.Delete(id);
            }
        }
      
        /// <summary>
        /// Model转Entity
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private xy_sp_outfitequipment ModelToEntity(V_xy_sp_outfitequipment model)
        {
            if (model != null)
            {
                xy_sp_outfitequipment entity = new xy_sp_outfitequipment()
                {
                	                    	OutfitEquipmentID = model.OutfitEquipmentID,
                                        	OutfitID = model.OutfitID,
                                        	EquipmentID = model.EquipmentID,
                                        	EquipmentType = model.EquipmentType,
                                        	gainType = model.gainType,
                                        	gainValue = model.gainValue,
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
        private V_xy_sp_outfitequipment  EntityToModel(xy_sp_outfitequipment  entity)
        {
            if (entity != null)
            {
                V_xy_sp_outfitequipment  model = new V_xy_sp_outfitequipment ()
                {
                                       	OutfitEquipmentID = entity.OutfitEquipmentID,
                                        	OutfitID = entity.OutfitID,
                                        	EquipmentID = entity.EquipmentID,
                                        	EquipmentType = entity.EquipmentType,
                                        	gainType = entity.gainType,
                                        	gainValue = entity.gainValue,
                                    };

                return model;
            }

            return null;
        }

       
    }
}
