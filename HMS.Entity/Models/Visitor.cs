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
    
    public partial class Visitor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Nic { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.TimeSpan> InTime { get; set; }
        public Nullable<System.TimeSpan> OutTime { get; set; }
        public string Purpose { get; set; }
        public string Note { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<bool> Active { get; set; }
        public string MobileNo { get; set; }
    }
}
