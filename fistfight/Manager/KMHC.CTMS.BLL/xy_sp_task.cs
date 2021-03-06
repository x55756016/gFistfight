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
    public class xy_sp_taskBLL
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Add(V_xy_sp_task model)
        {
             if (model == null)
                return string.Empty;
                
  			using(xy_sp_taskDAL dal = new xy_sp_taskDAL()){              
            xy_sp_task entity = ModelToEntity(model);
            entity.TaskID = string.IsNullOrEmpty(model.TaskID) ? Guid.NewGuid().ToString("N") : model.TaskID;

            return dal.Add(entity);
            }
        }
		
		/// <summary>
        /// 获取单条数据
        /// </summary>
        /// <returns></returns>
        public V_xy_sp_task Get(Expression<Func<xy_sp_task, bool>> predicate = null)
        {
        	using(xy_sp_taskDAL dal = new xy_sp_taskDAL()){        
	            xy_sp_task entity= dal.Get(predicate);
	            return EntityToModel(entity); 
            }
        }


        /// <summary>
        /// 获取单条数据
        /// </summary>
        /// <returns></returns>
        public string GetNextTaskIDByTaskID(string TaskID)
        {
            string taskID = string.Empty;
            using (xy_sp_taskDAL dal = new xy_sp_taskDAL())
            {
                taskID = (from ent in dal.Get()
                                       where ent.PreviousTaskID ==TaskID
                                       select ent.TaskID).FirstOrDefault();
                return taskID;
            }
        }
		
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<V_xy_sp_task> Get()
        {
        	using(xy_sp_taskDAL dal = new xy_sp_taskDAL()){        
	            List<xy_sp_task> entitys = dal.Get().ToList();
	            List<V_xy_sp_task> list = new List<V_xy_sp_task>();
	            foreach (xy_sp_task item in entitys)
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
        public IEnumerable<V_xy_sp_task> GetList(PageInfo page)
        {
        	using(xy_sp_taskDAL dal = new xy_sp_taskDAL()){        
	            var list = dal.Get();
	
	            return list.Paging(ref page).Select(EntityToModel).ToList();
            }
        }
		
		/// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Edit(V_xy_sp_task model)
        {
            if (model == null) return false;
            using(xy_sp_taskDAL dal = new xy_sp_taskDAL()){        
	            xy_sp_task entitys = ModelToEntity(model);
	            
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
			using(xy_sp_taskDAL dal = new xy_sp_taskDAL()){        
           		return dal.Delete(id);
            }
        }

        public V_xy_sp_task getTaskContext(string strTaskID)
        {
            using (xy_sp_userspiritDAL dal = new xy_sp_userspiritDAL())
            {
                xy_sp_spiritBLL spBll = new xy_sp_spiritBLL();               
                var q = from Task in dal._context.xy_sp_task
                        where Task.TaskID == strTaskID
                        select Task;
                V_xy_sp_task task =EntityToModel(q.FirstOrDefault());

                var taskSpirit = from TaskSpirit in dal._context.xy_sp_taskspirit
                                 where TaskSpirit.TaskID == strTaskID
                                 select TaskSpirit;

                foreach (var item in taskSpirit)
                {
                    V_xy_sp_spirit spirit = spBll.getSpiritContextByID(item.SpiritID);                 

                    task.SpiritsList.Add(spirit);
                }
                return task;
            }
        }
      
        /// <summary>
        /// Model转Entity
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public xy_sp_task ModelToEntity(V_xy_sp_task model)
        {
            if (model != null)
            {
                xy_sp_task entity = new xy_sp_task()
                {
                	                    	TaskID = model.TaskID,
                                        	AddrID = model.AddrID,
                                        	AddrName = model.AddrName,
                                        	AddrX = model.AddrX,
                                        	AddrY = model.AddrY,
                                        	chapterID = model.chapterID,
                                        	chapterName = model.chapterName,
                                        	TaskName = model.TaskName,
                                        	TaskDescript = model.TaskDescript,
                                        	NpcName = model.NpcName,
                                        	IsBattleTask = model.IsBattleTask,
                                        	IsOptionTask = model.IsOptionTask,
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
        public V_xy_sp_task EntityToModel(xy_sp_task entity)
        {
            if (entity != null)
            {
                V_xy_sp_task model = new V_xy_sp_task()
                {
                    TaskID = entity.TaskID,
                    AddrID = entity.AddrID,
                    AddrName = entity.AddrName,
                    AddrX = entity.AddrX,
                    AddrY = entity.AddrY,
                    chapterID = entity.chapterID,
                    chapterName = entity.chapterName,
                    TaskName = entity.TaskName,
                    TaskDescript = entity.TaskDescript,
                    NpcName = entity.NpcName,
                    IsBattleTask = entity.IsBattleTask,
                    IsOptionTask = entity.IsOptionTask,
                    NextTaskID = entity.NextTaskID,
                    PreviousTaskID = entity.PreviousTaskID,

                };

                return model;
            }

            return null;
        }

       
    }
}
