﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Gym_SystemEntities6 : DbContext
    {
        public Gym_SystemEntities6()
            : base("name=Gym_SystemEntities6")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<membership_report_table> membership_report_table { get; set; }
        public virtual DbSet<membership_type_table> membership_type_table { get; set; }
        public virtual DbSet<new_member_table> new_member_table { get; set; }
        public virtual DbSet<renew> renews { get; set; }
        public virtual DbSet<setting_table> setting_table { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<password_table> password_table { get; set; }
        public virtual DbSet<revenue_report> revenue_report { get; set; }
    }
}
