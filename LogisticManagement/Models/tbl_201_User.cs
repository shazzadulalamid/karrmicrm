//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LogisticManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_201_User
    {
        public int AutoId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string StakeHolderUniqueCode { get; set; }
        public Nullable<int> UserRoleId { get; set; }
        public Nullable<int> UserStatus { get; set; }
    }
}
