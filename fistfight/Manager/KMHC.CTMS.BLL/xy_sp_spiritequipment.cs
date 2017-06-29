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
    public class xy_sp_spiritequipmentBLL
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Add(V_xy_sp_spiritequipment model)
        {
            if (model == null)
                return string.Empty;

            using (xy_sp_spiritequipmentDAL dal = new xy_sp_spiritequipmentDAL())
            {
                xy_sp_spiritequipment entity = ModelToEntity(model);
                entity.SpiritEquipment = string.IsNullOrEmpty(model.SpiritEquipment) ? Guid.NewGuid().ToString("N") : model.SpiritEquipment;

                return dal.Add(entity);
            }
        }

        /// <summary>
        /// 获取单条数据
        /// </summary>
        /// <returns></returns>
        public V_xy_sp_spiritequipment Get(Expression<Func<xy_sp_spiritequipment, bool>> predicate = null)
        {
            using (xy_sp_spiritequipmentDAL dal = new xy_sp_spiritequipmentDAL())
            {
                xy_sp_spiritequipment entity = dal.Get(predicate);
                return EntityToModel(entity);
            }
        }

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<V_xy_sp_spiritequipment> Get()
        {
            using (xy_sp_spiritequipmentDAL dal = new xy_sp_spiritequipmentDAL())
            {
                List<xy_sp_spiritequipment> entitys = dal.Get().ToList();
                List<V_xy_sp_spiritequipment> list = new List<V_xy_sp_spiritequipment>();
                foreach (xy_sp_spiritequipment item in entitys)
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
        public IEnumerable<V_xy_sp_spiritequipment> GetList(PageInfo page)
        {
            using (xy_sp_spiritequipmentDAL dal = new xy_sp_spiritequipmentDAL())
            {
                var list = dal.Get();

                return list.Paging(ref page).Select(EntityToModel).ToList();
            }
        }

        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public List<V_xy_sp_spiritequipment> GetSpEqListBySpID(string SpID)
        {
            using (xy_sp_spiritequipmentDAL dal = new xy_sp_spiritequipmentDAL())
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
        public bool Edit(V_xy_sp_spiritequipment model)
        {
            if (model == null) return false;
            using (xy_sp_spiritequipmentDAL dal = new xy_sp_spiritequipmentDAL())
            {
                xy_sp_spiritequipment entitys = ModelToEntity(model);

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
            using (xy_sp_spiritequipmentDAL dal = new xy_sp_spiritequipmentDAL())
            {
                return dal.Delete(id);
            }
        }

        /// <summary>
        /// Model转Entity
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private xy_sp_spiritequipment ModelToEntity(V_xy_sp_spiritequipment model)
        {
            if (model != null)
            {
                xy_sp_spiritequipment entity = new xy_sp_spiritequipment()
                {
                    SpiritEquipment = model.SpiritEquipment,
                    SpiritID = model.SpiritID,
                    EquipmentID = model.EquipmentID,
                    LostRate = model.LostRate
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
        private V_xy_sp_spiritequipment EntityToModel(xy_sp_spiritequipment entity)
        {
            if (entity != null)
            {
                xy_sp_equipmentBLL bll = new xy_sp_equipmentBLL();
                V_xy_sp_spiritequipment model = new V_xy_sp_spiritequipment()
                {
                    SpiritEquipment = entity.SpiritEquipment,
                    SpiritID = entity.SpiritID,
                    EquipmentID = entity.EquipmentID,
                    LostRate = entity.LostRate,
                    equipment = bll.Get(c => c.EquipmentID == entity.EquipmentID)

                };
                return model;
            }

            return null;
        }


    }
}
