//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.DAL.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class xy_sp_userinfo
    {
        public string UserId { get; set; }
        public string LoginName { get; set; }
        public string UserName { get; set; }
        public string LoginPwd { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public Nullable<decimal> UserType { get; set; }
        public Nullable<decimal> UserStatus { get; set; }
        public string MemberID { get; set; }
        public Nullable<System.DateTime> MemberStartDate { get; set; }
        public Nullable<System.DateTime> MemberEndDate { get; set; }
        public decimal Account { get; set; }
        public string ICONPATH { get; set; }
        public string CreateUserName { get; set; }
        public string EditUserName { get; set; }
        public string OwnerName { get; set; }
        public string CreateUserId { get; set; }
        public Nullable<System.DateTime> CreateDateTime { get; set; }
        public string EditUserId { get; set; }
        public Nullable<System.DateTime> EditDateTime { get; set; }
        public Nullable<decimal> IsDeleted { get; set; }
    }
}