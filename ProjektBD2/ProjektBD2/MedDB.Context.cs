﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektBD2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MedDBContainer : DbContext
    {
        public MedDBContainer()
            : base("name=MedDBContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<HCO> HCOSet { get; set; }
        public virtual DbSet<HCP> HCPSet { get; set; }
        public virtual DbSet<Address> AddressSet { get; set; }
        public virtual DbSet<Meeting> MeetingSet { get; set; }
        public virtual DbSet<User> UserSet { get; set; }
        public virtual DbSet<Product> ProductSet { get; set; }
        public virtual DbSet<UserCredentialsSet> UserCredentialsSet1 { get; set; }
    }
}
