/*
 * 描述:
 *  
 * 修订历史: 
 * 日期                    修改人              Email                   内容
 * 2015-12-02                                         创建 
 *  
 */

using System;

namespace Project.Model
{
    public class V_tm_pm_userinfo
    {
        /// <summary>
        /// USERID
        /// </summary>
        public string USERID { get; set; }

        /// <summary>
        /// OWNERID
        /// </summary>
        public string OWNERID { get; set; }

        /// <summary>
        /// ISDELETED
        /// </summary>
        public bool ISDELETED { get; set; }

        /// <summary>
        /// CREATEUSERNAME
        /// </summary>
        public string CREATEUSERNAME { get; set; }

        /// <summary>
        /// EDITUSERNAME
        /// </summary>
        public string EDITUSERNAME { get; set; }

        /// <summary>
        /// OWNERNAME
        /// </summary>
        public string OWNERNAME { get; set; }

        /// <summary>
        /// USERTYPE
        /// </summary>
        public Nullable<int> USERTYPE { get; set; }

        /// <summary>
        /// LOGINNAME
        /// </summary>
        public string LOGINNAME { get; set; }

        /// <summary>
        /// LOGINPWD
        /// </summary>
        public string LOGINPWD { get; set; }

        /// <summary>
        /// MOBILEPHONE
        /// </summary>
        public string MOBILEPHONE { get; set; }

        /// <summary>
        /// EMAIL
        /// </summary>
        public string EMAIL { get; set; }

        /// <summary>
        /// CREATEUSERID
        /// </summary>
        public string CREATEUSERID { get; set; }

        /// <summary>
        /// CREATEDATETIME
        /// </summary>
        public Nullable<DateTime> CREATEDATETIME { get; set; }

        /// <summary>
        /// EDITUSERID
        /// </summary>
        public string EDITUSERID { get; set; }

        /// <summary>
        /// EDITDATETIME
        /// </summary>
        public Nullable<DateTime> EDITDATETIME { get; set; }

        /// <summary>
        /// 确认密码
        /// </summary>
        public string ConfirmLoginPwd { get; set; }

    }
}