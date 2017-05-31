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
    public class xy_sp_skillBLL
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Add(V_xy_sp_skill model)
        {
             if (model == null)
                return string.Empty;
                
  			using(xy_sp_skillDAL dal = new xy_sp_skillDAL()){              
            xy_sp_skill entity = ModelToEntity(model);
            entity.SkillID = string.IsNullOrEmpty(model.SkillID) ? Guid.NewGuid().ToString("N") : model.SkillID;

            return dal.Add(entity);
            }
        }
		
		/// <summary>
        /// 获取单条数据
        /// </summary>
        /// <returns></returns>
        public V_xy_sp_skill Get(Expression<Func<xy_sp_skill, bool>> predicate = null)
        {
        	using(xy_sp_skillDAL dal = new xy_sp_skillDAL()){        
	            xy_sp_skill entity= dal.Get(predicate);
	            return EntityToModel(entity); 
            }
        }
		
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<V_xy_sp_skill> Get()
        {
        	using(xy_sp_skillDAL dal = new xy_sp_skillDAL()){        
	            List<xy_sp_skill> entitys = dal.Get().ToList();
	            List<V_xy_sp_skill> list = new List<V_xy_sp_skill>();
	            foreach (xy_sp_skill item in entitys)
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
        public IEnumerable<V_xy_sp_skill> GetList(PageInfo page)
        {
        	using(xy_sp_skillDAL dal = new xy_sp_skillDAL()){        
	            var list = dal.Get();
	
	            return list.Paging(ref page).Select(EntityToModel).ToList();
            }
        }
		
		/// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Edit(V_xy_sp_skill model)
        {
            if (model == null) return false;
            using(xy_sp_skillDAL dal = new xy_sp_skillDAL()){        
	            xy_sp_skill entitys = ModelToEntity(model);
	            
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
			using(xy_sp_skillDAL dal = new xy_sp_skillDAL()){        
           		return dal.Delete(id);
            }
        }
      
        /// <summary>
        /// Model转Entity
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private xy_sp_skill ModelToEntity(V_xy_sp_skill model)
        {
            if (model != null)
            {
                xy_sp_skill entity = new xy_sp_skill()
                {
                	                    	SkillID = model.SkillID,
                                        	SkillName = model.SkillName,
                                        	SkillDescription = model.SkillDescription,
                                        	SkillPathPrompt = model.SkillPathPrompt,
                                        	SkillType = model.SkillType,
                                        	SkillGainValue = model.SkillGainValue,
                                        	ExpendType = model.ExpendType,
                                        	ExpendValue = model.ExpendValue,
                                        	isGroupinjury = model.isGroupinjury,
                                        	injuryCount = model.injuryCount,
                                        	NeedLevel = model.NeedLevel,
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
        private V_xy_sp_skill  EntityToModel(xy_sp_skill  entity)
        {
            if (entity != null)
            {
                V_xy_sp_skill  model = new V_xy_sp_skill ()
                {
                                       	SkillID = entity.SkillID,
                                        	SkillName = entity.SkillName,
                                        	SkillDescription = entity.SkillDescription,
                                        	SkillPathPrompt = entity.SkillPathPrompt,
                                        	SkillType = entity.SkillType,
                                        	SkillGainValue = entity.SkillGainValue,
                                        	ExpendType = entity.ExpendType,
                                        	ExpendValue = entity.ExpendValue,
                                        	isGroupinjury = entity.isGroupinjury,
                                        	injuryCount = entity.injuryCount,
                                        	NeedLevel = entity.NeedLevel,
                                    };

                return model;
            }

            return null;
        }

       
    }
}
