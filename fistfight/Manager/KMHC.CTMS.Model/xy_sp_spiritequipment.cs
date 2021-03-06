﻿/*
 * 描述:
 *  
 * 修订历史: 
 * 日期                    修改人              Email                   内容
 * 2017-06-15                                         创建 
 *  
 */
 
using System;

namespace Project.Model
{
    [Serializable]
    public class V_xy_sp_spiritequipment
    {
        /// <summary>
        /// SpiritEquipment
        /// </summary>
        public string SpiritEquipment { get; set; }

        /// <summary>
        /// SpiritID
        /// </summary>
        public string SpiritID { get; set; }

        /// <summary>
        /// EquipmentID
        /// </summary>
        public string EquipmentID { get; set; }

        /// <summary>
        /// LostRate
        /// </summary>
        public Nullable<decimal> LostRate { get; set; }
        public V_xy_sp_equipment equipment { get; set; }

    }
}