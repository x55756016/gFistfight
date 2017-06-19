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
    public class xy_sp_userspiritBLL
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Add(V_xy_sp_userspirit model)
        {
             if (model == null)
                return string.Empty;
                
  			using(xy_sp_userspiritDAL dal = new xy_sp_userspiritDAL()){              
            xy_sp_userspirit entity = ModelToEntity(model);
            entity.UserSpiritID = string.IsNullOrEmpty(model.UserSpiritID) ? Guid.NewGuid().ToString("N") : model.UserSpiritID;

            return dal.Add(entity);
            }
        }
		
		/// <summary>
        /// 获取单条数据
        /// </summary>
        /// <returns></returns>
        public V_xy_sp_userspirit Get(Expression<Func<xy_sp_userspirit, bool>> predicate = null)
        {
        	using(xy_sp_userspiritDAL dal = new xy_sp_userspiritDAL()){        
	            xy_sp_userspirit entity= dal.Get(predicate);
	            return EntityToModel(entity); 
            }
        }
		
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<V_xy_sp_userspirit> Get()
        {
        	using(xy_sp_userspiritDAL dal = new xy_sp_userspiritDAL()){        
	            List<xy_sp_userspirit> entitys = dal.Get().ToList();
	            List<V_xy_sp_userspirit> list = new List<V_xy_sp_userspirit>();
	            foreach (xy_sp_userspirit item in entitys)
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
        public IEnumerable<V_xy_sp_userspirit> GetList(PageInfo page)
        {
        	using(xy_sp_userspiritDAL dal = new xy_sp_userspiritDAL()){        
	            var list = dal.Get();
	
	            return list.Paging(ref page).Select(EntityToModel).ToList();
            }
        }
		
		/// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Edit(V_xy_sp_userspirit model)
        {
            if (model == null) return false;
            using(xy_sp_userspiritDAL dal = new xy_sp_userspiritDAL()){        
	            xy_sp_userspirit entitys = ModelToEntity(model);
	            
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
			using(xy_sp_userspiritDAL dal = new xy_sp_userspiritDAL()){        
           		return dal.Delete(id);
            }
        }
      
        /// <summary>
        /// Model转Entity
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private xy_sp_userspirit ModelToEntity(V_xy_sp_userspirit model)
        {
            if (model != null)
            {
                xy_sp_userspirit entity = new xy_sp_userspirit()
                {
                	                    	UserSpiritID = model.UserSpiritID,
                                        	UserId = model.UserId,
                                        	SpiritID = model.SpiritID,
                                        	SpiritName = model.SpiritName,
                                        	SpiritLifeMax = model.SpiritLifeMax,
                                        	SpiritMagicMax = model.SpiritMagicMax,
                                        	SpiritLife = model.SpiritLife,
                                        	SpiritMagic = model.SpiritMagic,
                                        	PhysicalResistance = model.PhysicalResistance,
                                        	MagicResistance = model.MagicResistance,
                                        	SpiritLevel = model.SpiritLevel,
                                        	SpiritExperience = model.SpiritExperience,
                                        	SpiritMoney = model.SpiritMoney,
                                        	PhysicalHarm = model.PhysicalHarm,
                                        	MagicHarm = model.MagicHarm,
                                        	Spiritspeed = model.Spiritspeed,
                                        	CurrentTaskID = model.CurrentTaskID,
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
        private V_xy_sp_userspirit  EntityToModel(xy_sp_userspirit  entity)
        {
            if (entity != null)
            {
                V_xy_sp_userspirit  model = new V_xy_sp_userspirit ()
                {
                                       	UserSpiritID = entity.UserSpiritID,
                                        	UserId = entity.UserId,
                                        	SpiritID = entity.SpiritID,
                                        	SpiritName = entity.SpiritName,
                                        	SpiritLifeMax = entity.SpiritLifeMax,
                                        	SpiritMagicMax = entity.SpiritMagicMax,
                                        	SpiritLife = entity.SpiritLife,
                                        	SpiritMagic = entity.SpiritMagic,
                                        	PhysicalResistance = entity.PhysicalResistance,
                                        	MagicResistance = entity.MagicResistance,
                                        	SpiritLevel = entity.SpiritLevel,
                                        	SpiritExperience = entity.SpiritExperience,
                                        	SpiritMoney = entity.SpiritMoney,
                                        	PhysicalHarm = entity.PhysicalHarm,
                                        	MagicHarm = entity.MagicHarm,
                                        	Spiritspeed = entity.Spiritspeed,
                                        	CurrentTaskID = entity.CurrentTaskID,
                                    };

                return model;
            }

            return null;
        }

       
    }
}
