﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AndroidContact
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CContactEntities : DbContext
    {
        public CContactEntities()
            : base("name=CContactEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<appointment> appointments { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<commune> communes { get; set; }
        public virtual DbSet<data_rows> data_rows { get; set; }
        public virtual DbSet<data_types> data_types { get; set; }
        public virtual DbSet<device_tokens> device_tokens { get; set; }
        public virtual DbSet<district> districts { get; set; }
        public virtual DbSet<failed_jobs> failed_jobs { get; set; }
        public virtual DbSet<hospital> hospitals { get; set; }
        public virtual DbSet<log> logs { get; set; }
        public virtual DbSet<menu_items> menu_items { get; set; }
        public virtual DbSet<menu> menus { get; set; }
        public virtual DbSet<migration> migrations { get; set; }
        public virtual DbSet<notification> notifications { get; set; }
        public virtual DbSet<organization> organizations { get; set; }
        public virtual DbSet<page> pages { get; set; }
        public virtual DbSet<permission> permissions { get; set; }
        public virtual DbSet<position> positions { get; set; }
        public virtual DbSet<post> posts { get; set; }
        public virtual DbSet<province> provinces { get; set; }
        public virtual DbSet<reason> reasons { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<setting> settings { get; set; }
        public virtual DbSet<translation> translations { get; set; }
        public virtual DbSet<user_roles> user_roles { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<vaccine> vaccines { get; set; }
        public virtual DbSet<verify_phones> verify_phones { get; set; }
        public virtual DbSet<village> villages { get; set; }
        public virtual DbSet<auth_tokens> auth_tokens { get; set; }
        public virtual DbSet<dbo_members> dbo_members { get; set; }
        public virtual DbSet<password_resets> password_resets { get; set; }
    }
}
