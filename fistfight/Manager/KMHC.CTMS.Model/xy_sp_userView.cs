/*
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
    public class V_xy_sp_userView
    {
        public V_xy_sp_userView()
        {
            Spirit = new V_xy_sp_userspirit();
            Task = new V_xy_sp_task();
        }
        public V_tm_pm_userinfo User { get; set; }

        public V_xy_sp_userspirit Spirit { get; set; }

        public V_xy_sp_task Task { get; set; }
    }
}