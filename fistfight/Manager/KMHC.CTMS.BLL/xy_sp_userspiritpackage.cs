/*
 * 描述:
 *  
 * 修订历史: 
 * 日期                    修改人              Email                   内容
 * 2017-06-27                                         创建 
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
    public class xy_sp_userspiritpackageBLL
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Add(V_xy_sp_userspiritpackage model)
        {
             if (model == null)
                return string.Empty;
                
  			using(xy_sp_userspiritpackageDAL dal = new xy_sp_userspiritpackageDAL()){              
            xy_sp_userspiritpackage entity = ModelToEntity(model);
            entity.SpiritPackageID = string.IsNullOrEmpty(model.SpiritPackageID) ? Guid.NewGuid().ToString("N") : model.SpiritPackageID;

            return dal.Add(entity);
            }
        }
		
		/// <summary>
        /// 获取单条数据
        /// </summary>
        /// <returns></returns>
        public V_xy_sp_userspiritpackage Get(Expression<Func<xy_sp_userspiritpackage, bool>> predicate = null)
        {
        	using(xy_sp_userspiritpackageDAL dal = new xy_sp_userspiritpackageDAL()){        
	            xy_sp_userspiritpackage entity= dal.Get(predicate);
	            return EntityToModel(entity); 
            }
        }
        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public List<V_xy_sp_userspiritpackage> GetSpPackageListBySpID(string SpID)
        {
            using (xy_sp_userspiritpackageDAL dal = new xy_sp_userspiritpackageDAL())
            {
                var list = from ent in dal.Get()
                           where ent.UserSpiritID == SpID
                           select ent;

                return list.Select(EntityToModel).ToList();
            }
        }
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<V_xy_sp_userspiritpackage> Get()
        {
        	using(xy_sp_userspiritpackageDAL dal = new xy_sp_userspiritpackageDAL()){        
	            List<xy_sp_userspiritpackage> entitys = dal.Get().ToList();
	            List<V_xy_sp_userspiritpackage> list = new List<V_xy_sp_userspiritpackage>();
	            foreach (xy_sp_userspiritpackage item in entitys)
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
        public IEnumerable<V_xy_sp_userspiritpackage> GetList(PageInfo page)
        {
        	using(xy_sp_userspiritpackageDAL dal = new xy_sp_userspiritpackageDAL()){        
	            var list = dal.Get();
	
	            return list.Paging(ref page).Select(EntityToModel).ToList();
            }
        }
		
		/// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Edit(V_xy_sp_userspiritpackage model)
        {
            if (model == null) return false;
            using(xy_sp_userspiritpackageDAL dal = new xy_sp_userspiritpackageDAL()){        
	            xy_sp_userspiritpackage entitys = ModelToEntity(model);
	            
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
			using(xy_sp_userspiritpackageDAL dal = new xy_sp_userspiritpackageDAL()){        
           		return dal.Delete(id);
            }
        }
      
        /// <summary>
        /// Model转Entity
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private xy_sp_userspiritpackage ModelToEntity(V_xy_sp_userspiritpackage model)
        {
            if (model != null)
            {
                xy_sp_userspiritpackage entity = new xy_sp_userspiritpackage()
                {
                	                    	SpiritPackageID = model.SpiritPackageID,
                                        	UserSpiritID = model.UserSpiritID,
                                        	EquipmentID = model.EquipmentID,
                                        	LostRate = model.LostRate,
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
        private V_xy_sp_userspiritpackage  EntityToModel(xy_sp_userspiritpackage  entity)
        {
            if (entity != null)
            {
                V_xy_sp_userspiritpackage  model = new V_xy_sp_userspiritpackage ()
                {
                                       	SpiritPackageID = entity.SpiritPackageID,
                                        	UserSpiritID = entity.UserSpiritID,
                                        	EquipmentID = entity.EquipmentID,
                                        	LostRate = entity.LostRate,
                                    };

                return model;
            }

            return null;
        }

       
    }
}
