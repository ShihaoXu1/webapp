//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cook.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int UserId { get; set; }
        public string PasswordHash { get; set; }
        public Nullable<int> GenderId { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public string UserName { get; set; }
        public string BriefInstroduction { get; set; }
        public Nullable<System.DateTime> RegisterTime { get; set; }
        public int UserRoleId { get; set; }
    
        public virtual Gender Gender { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
