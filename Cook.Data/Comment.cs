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
    
    public partial class Comment
    {
        public int ReplyId { get; set; }
        public string CommentContent { get; set; }
        public Nullable<int> PostId { get; set; }
        public int UserId { get; set; }
        public Nullable<System.DateTime> Replytime { get; set; }
        public bool Visible { get; set; }
    
        public virtual Post Post { get; set; }
    }
}
