/*
 * 描述:
 *  
 * 修订历史: 
 * 日期                    修改人              Email                   内容
 * 2017-06-15                                         创建 
 *  
 */
 
using System;
using System.Collections.Generic;

namespace Project.Model
{
    public class V_xy_sp_spirit
    {
        public V_xy_sp_spirit()
        {
            spiritEquipmentList = new List<V_xy_sp_equipment>();
            spiritSkillList = new List<V_xy_sp_skill>();

        }
        /// <summary>
        /// SpiritID
        /// </summary>
        public string SpiritID { get; set; }

        /// <summary>
        /// SpiritName
        /// </summary>
        public string SpiritName { get; set; }

        /// <summary>
        /// SpiritLife
        /// </summary>
        public Nullable<decimal> SpiritLife { get; set; }

        /// <summary>
        /// SpiritMagic
        /// </summary>
        public Nullable<decimal> SpiritMagic { get; set; }

        /// <summary>
        /// PhysicalResistance
        /// </summary>
        public Nullable<decimal> PhysicalResistance { get; set; }

        /// <summary>
        /// MagicResistance
        /// </summary>
        public Nullable<decimal> MagicResistance { get; set; }

        /// <summary>
        /// SpiritLevel
        /// </summary>
        public Nullable<decimal> SpiritLevel { get; set; }

        /// <summary>
        /// SpiritExperience
        /// </summary>
        public Nullable<decimal> SpiritExperience { get; set; }

        /// <summary>
        /// SpiritMoney
        /// </summary>
        public Nullable<decimal> SpiritMoney { get; set; }

        /// <summary>
        /// PhysicalHarm
        /// </summary>
        public Nullable<decimal> PhysicalHarm { get; set; }

        /// <summary>
        /// MagicHarm
        /// </summary>
        public Nullable<decimal> MagicHarm { get; set; }

        /// <summary>
        /// Spiritspeed
        /// </summary>
        public Nullable<decimal> Spiritspeed { get; set; }

        /// <summary>
        /// 精灵装备
        /// </summary>
        public List<V_xy_sp_equipment> spiritEquipmentList { get; set; }
        /// <summary>
        /// 精灵技能
        /// </summary>
        public List<V_xy_sp_skill> spiritSkillList { get; set; }

    }
}