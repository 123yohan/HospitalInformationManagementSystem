//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HMS.Entity.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Complaint
    {
        public int ComplainId { get; set; }
        public string Decription { get; set; }
        public string Type { get; set; }
        public string MobileNo { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Action { get; set; }
        public string AttachFiles { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> StaffId { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
