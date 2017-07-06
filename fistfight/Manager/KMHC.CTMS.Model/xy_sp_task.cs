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
    public class V_xy_sp_task
    {

        public V_xy_sp_task()
        {
            SpiritsList = new List<V_xy_sp_spirit>();
        }
        /// <summary>
        /// TaskID
        /// </summary>
        public string TaskID { get; set; }

        /// <summary>
        /// AddrID
        /// </summary>
        public string AddrID { get; set; }

        /// <summary>
        /// AddrName
        /// </summary>
        public string AddrName { get; set; }

        /// <summary>
        /// AddrX
        /// </summary>
        public Nullable<decimal> AddrX { get; set; }

        /// <summary>
        /// AddrY
        /// </summary>
        public Nullable<decimal> AddrY { get; set; }

        /// <summary>
        /// chapterID
        /// </summary>
        public string chapterID { get; set; }

        /// <summary>
        /// chapterName
        /// </summary>
        public string chapterName { get; set; }

        /// <summary>
        /// TaskName
        /// </summary>
        public string TaskName { get; set; }

        /// <summary>
        /// TaskDescript
        /// </summary>
        public string TaskDescript { get; set; }

        /// <summary>
        /// NpcName
        /// </summary>
        public string NpcName { get; set; }

        /// <summary>
        /// IsBattleTask
        /// </summary>
        public Nullable<decimal> IsBattleTask { get; set; }

        /// <summary>
        /// IsOptionTask
        /// </summary>
        public Nullable<decimal> IsOptionTask { get; set; }

        /// <summary>
        /// NextTaskID
        /// </summary>
        public string NextTaskID { get; set; }

        /// <summary>
        /// PreviousTaskID
        /// </summary>
        public string PreviousTaskID { get; set; }



        public List<V_xy_sp_spirit> SpiritsList { get; set; }

    }
}