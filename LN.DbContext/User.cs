//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LN.DbContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> EmployeeID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<System.Guid> ModifidedBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
