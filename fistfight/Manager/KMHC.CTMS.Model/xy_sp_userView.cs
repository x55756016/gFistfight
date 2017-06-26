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
    public class xy_sp_userView
    {
        public V_xy_sp_userinfo UserInfo { get; set; }

        public V_xy_sp_userspirit UserSpirit { get; set; }

        public V_xy_sp_task CurrentTask { get; set; }
    }
}