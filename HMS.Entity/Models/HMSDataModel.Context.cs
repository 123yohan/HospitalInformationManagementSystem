﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UOVT_HIMSEntities : DbContext
    {
        public UOVT_HIMSEntities()
            : base("name=UOVT_HIMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<UserRoleAccessLevel> UserRoleAccessLevels { get; set; }
        public virtual DbSet<Complaint> Complaints { get; set; }
        public virtual DbSet<AppointmentManager> AppointmentManagers { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
    }
}
