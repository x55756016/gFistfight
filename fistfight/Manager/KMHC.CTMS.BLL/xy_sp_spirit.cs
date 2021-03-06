﻿/*
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
    public class xy_sp_spiritBLL
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Add(V_xy_sp_spirit model)
        {
             if (model == null)
                return string.Empty;
                
  			using(xy_sp_spiritDAL dal = new xy_sp_spiritDAL()){              
            xy_sp_spirit entity = ModelToEntity(model);
            entity.SpiritID = string.IsNullOrEmpty(model.SpiritID) ? Guid.NewGuid().ToString("N") : model.SpiritID;

            return dal.Add(entity);
            }
        }
		
		/// <summary>
        /// 获取单条数据
        /// </summary>
        /// <returns></returns>
        public V_xy_sp_spirit Get(Expression<Func<xy_sp_spirit, bool>> predicate = null)
        {
        	using(xy_sp_spiritDAL dal = new xy_sp_spiritDAL()){        
	            xy_sp_spirit entity= dal.Get(predicate);
	            return EntityToModel(entity); 
            }
        }
		
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<V_xy_sp_spirit> Get()
        {
        	using(xy_sp_spiritDAL dal = new xy_sp_spiritDAL()){        
	            List<xy_sp_spirit> entitys = dal.Get().ToList();
	            List<V_xy_sp_spirit> list = new List<V_xy_sp_spirit>();
	            foreach (xy_sp_spirit item in entitys)
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
        public IEnumerable<V_xy_sp_spirit> GetList(PageInfo page)
        {
        	using(xy_sp_spiritDAL dal = new xy_sp_spiritDAL()){        
	            var list = dal.Get();
	
	            return list.Paging(ref page).Select(EntityToModel).ToList();
            }
        }
		
		/// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Edit(V_xy_sp_spirit model)
        {
            if (model == null) return false;
            using(xy_sp_spiritDAL dal = new xy_sp_spiritDAL()){        
	            xy_sp_spirit entitys = ModelToEntity(model);
	            
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
			using(xy_sp_spiritDAL dal = new xy_sp_spiritDAL()){        
           		return dal.Delete(id);
            }
        }

        public V_xy_sp_spirit getSpiritContextByID(string SpiritID)
        {
            xy_sp_equipmentBLL eqBll = new xy_sp_equipmentBLL();
            xy_sp_skillBLL skBll = new xy_sp_skillBLL();
            using (xy_sp_userspiritDAL dal = new xy_sp_userspiritDAL())
            {
                
                var q = from ent in dal._context.xy_sp_spirit
                        where ent.SpiritID == SpiritID
                        select ent;
                V_xy_sp_spirit spiritV = EntityToModel(q.FirstOrDefault());

                //查询装备
                var sps = from spEq in dal._context.xy_sp_spiritequipment
                          join eq in dal._context.xy_sp_equipment on spEq.EquipmentID equals eq.EquipmentID
                          where spEq.SpiritID == SpiritID
                          select eq;

                foreach (var spItem in sps)
                {
                    spiritV.spiritEquipmentList.Add(eqBll.EntityToModel(spItem));
                }

                //查询技能
                var sks = from SpiritSkill in dal._context.xy_sp_spiritskill
                          join Skill in dal._context.xy_sp_skill on SpiritSkill.SkillID equals Skill.SkillID
                          where SpiritSkill.SpiritID == SpiritID
                          select Skill;

                foreach (var skItem in sks)
                {
                    spiritV.spiritSkillList.Add(skBll.EntityToModel(skItem));
                }
                return spiritV;
            }
        }
      
        /// <summary>
        /// Model转Entity
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public xy_sp_spirit ModelToEntity(V_xy_sp_spirit model)
        {
            if (model != null)
            {
                xy_sp_spirit entity = new xy_sp_spirit()
                {
                	                    	SpiritID = model.SpiritID,
                                        	SpiritName = model.SpiritName,
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
        public V_xy_sp_spirit EntityToModel(xy_sp_spirit entity)
        {
            if (entity != null)
            {
                V_xy_sp_spirit  model = new V_xy_sp_spirit ()
                {
                                       	SpiritID = entity.SpiritID,
                                        	SpiritName = entity.SpiritName,
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
                                    };

                return model;
            }

            return null;
        }

       
    }
}
