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
    public class xy_sp_spiritskillBLL
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Add(V_xy_sp_spiritskill model)
        {
             if (model == null)
                return string.Empty;
                
  			using(xy_sp_spiritskillDAL dal = new xy_sp_spiritskillDAL()){
                xy_sp_spiritskill entity = ModelToEntity(model);
            entity.SpiritSkillID = string.IsNullOrEmpty(model.SpiritSkillID) ? Guid.NewGuid().ToString("N") : model.SpiritSkillID;

            return dal.Add(entity);
            }
        }
		
		/// <summary>
        /// 获取单条数据
        /// </summary>
        /// <returns></returns>
        public V_xy_sp_spiritskill Get(Expression<Func<xy_sp_spiritskill, bool>> predicate = null)
        {
        	using(xy_sp_spiritskillDAL dal = new xy_sp_spiritskillDAL()){        
	            xy_sp_spiritskill entity= dal.Get(predicate);
	            return EntityToModel(entity); 
            }
        }
		
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<V_xy_sp_spiritskill> Get()
        {
        	using(xy_sp_spiritskillDAL dal = new xy_sp_spiritskillDAL()){        
	            List<xy_sp_spiritskill> entitys = dal.Get().ToList();
	            List<V_xy_sp_spiritskill> list = new List<V_xy_sp_spiritskill>();
	            foreach (xy_sp_spiritskill item in entitys)
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
        public IEnumerable<V_xy_sp_spiritskill> GetList(PageInfo page)
        {
        	using(xy_sp_spiritskillDAL dal = new xy_sp_spiritskillDAL()){        
	            var list = dal.Get();
	
	            return list.Paging(ref page).Select(EntityToModel).ToList();
            }
        }

        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public List<V_xy_sp_spiritskill> GetListBySpID(string SpID)
        {
            using (xy_sp_spiritskillDAL dal = new xy_sp_spiritskillDAL())
            {
                var list = from ent in dal.Get()
                           where ent.SpiritID == SpID
                           select ent;

                return list.Select(EntityToModel).ToList();
            }
        }

		/// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Edit(V_xy_sp_spiritskill model)
        {
            if (model == null) return false;
            using(xy_sp_spiritskillDAL dal = new xy_sp_spiritskillDAL()){        
	            xy_sp_spiritskill entitys = ModelToEntity(model);
	            
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
			using(xy_sp_spiritskillDAL dal = new xy_sp_spiritskillDAL()){        
           		return dal.Delete(id);
            }
        }
      
        /// <summary>
        /// Model转Entity
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private xy_sp_spiritskill ModelToEntity(V_xy_sp_spiritskill model)
        {
            if (model != null)
            {
                xy_sp_spiritskill entity = new xy_sp_spiritskill()
                {
                	                    	SpiritSkillID = model.SpiritSkillID,
                                        	SpiritID = model.SpiritID,
                                        	SkillID = model.SkillID,
                                        	IsReady = model.IsReady,
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
        private V_xy_sp_spiritskill  EntityToModel(xy_sp_spiritskill  entity)
        {
            if (entity != null)
            {
                xy_sp_skillBLL bll=new xy_sp_skillBLL();
                V_xy_sp_spiritskill  model = new V_xy_sp_spiritskill ()
                {
                                       	SpiritSkillID = entity.SpiritSkillID,
                                        	SpiritID = entity.SpiritID,
                                        	SkillID = entity.SkillID,
                                        	IsReady = entity.IsReady,
                                            skill = bll.Get(c=>c.SkillID==entity.SkillID)
                                    };

                return model;
            }

            return null;
        }

       
    }
}
