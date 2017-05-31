﻿/*
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
    public class xy_sp_chapterBLL
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Add(V_xy_sp_chapter model)
        {
             if (model == null)
                return string.Empty;
                
  			using(xy_sp_chapterDAL dal = new xy_sp_chapterDAL()){              
            xy_sp_chapter entity = ModelToEntity(model);
            entity.chapterID = string.IsNullOrEmpty(model.chapterID) ? Guid.NewGuid().ToString("N") : model.chapterID;

            return dal.Add(entity);
            }
        }
		
		/// <summary>
        /// 获取单条数据
        /// </summary>
        /// <returns></returns>
        public V_xy_sp_chapter Get(Expression<Func<xy_sp_chapter, bool>> predicate = null)
        {
        	using(xy_sp_chapterDAL dal = new xy_sp_chapterDAL()){        
	            xy_sp_chapter entity= dal.Get(predicate);
	            return EntityToModel(entity); 
            }
        }
		
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<V_xy_sp_chapter> Get()
        {
        	using(xy_sp_chapterDAL dal = new xy_sp_chapterDAL()){        
	            List<xy_sp_chapter> entitys = dal.Get().ToList();
	            List<V_xy_sp_chapter> list = new List<V_xy_sp_chapter>();
	            foreach (xy_sp_chapter item in entitys)
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
        public IEnumerable<V_xy_sp_chapter> GetList(PageInfo page)
        {
        	using(xy_sp_chapterDAL dal = new xy_sp_chapterDAL()){        
	            var list = dal.Get();
	
	            return list.Paging(ref page).Select(EntityToModel).ToList();
            }
        }
		
		/// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Edit(V_xy_sp_chapter model)
        {
            if (model == null) return false;
            using(xy_sp_chapterDAL dal = new xy_sp_chapterDAL()){        
	            xy_sp_chapter entitys = ModelToEntity(model);
	            
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
			using(xy_sp_chapterDAL dal = new xy_sp_chapterDAL()){        
           		return dal.Delete(id);
            }
        }
      
        /// <summary>
        /// Model转Entity
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private xy_sp_chapter ModelToEntity(V_xy_sp_chapter model)
        {
            if (model != null)
            {
                xy_sp_chapter entity = new xy_sp_chapter()
                {
                	                    	chapterID = model.chapterID,
                                        	chapterName = model.chapterName,
                                        	chapterDescript = model.chapterDescript,
                                        	AddrID = model.AddrID,
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
        private V_xy_sp_chapter  EntityToModel(xy_sp_chapter  entity)
        {
            if (entity != null)
            {
                V_xy_sp_chapter  model = new V_xy_sp_chapter ()
                {
                                       	chapterID = entity.chapterID,
                                        	chapterName = entity.chapterName,
                                        	chapterDescript = entity.chapterDescript,
                                        	AddrID = entity.AddrID,
                                    };

                return model;
            }

            return null;
        }

       
    }
}