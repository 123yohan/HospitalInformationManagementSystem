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
    
    public partial class Appointment
    {
        public int AppoitmentId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public Nullable<bool> IsCompleted { get; set; }
    }
}
