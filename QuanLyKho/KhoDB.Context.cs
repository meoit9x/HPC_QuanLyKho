﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKho
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HPC_DBEntities : DbContext
    {
        public HPC_DBEntities()
            : base("name=HPC_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<dDVT> dDVT { get; set; }
        public DbSet<dEmail> dEmail { get; set; }
        public DbSet<dK> dK { get; set; }
        public DbSet<dKH> dKH { get; set; }
        public DbSet<dMay> dMay { get; set; }
        public DbSet<dNVT> dNVT { get; set; }
        public DbSet<dQC> dQC { get; set; }
        public DbSet<dQCCT> dQCCT { get; set; }
        public DbSet<duser> duser { get; set; }
        public DbSet<dVT> dVTs { get; set; }
        public DbSet<pC> pC { get; set; }
        public DbSet<pCCT> pCCT { get; set; }
        public DbSet<pN> pN { get; set; }
        public DbSet<pNC> pNC { get; set; }
        public DbSet<pNCCT> pNCCT { get; set; }
        public DbSet<pNCT> pNCT { get; set; }
        public DbSet<pSD> pSD { get; set; }
        public DbSet<pSDCT> pSDCT { get; set; }
        public DbSet<pTB> pTB { get; set; }
        public DbSet<pTon> pTon { get; set; }
    }
}
