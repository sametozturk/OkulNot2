﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OkulNot.Models.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OkulEntities : DbContext
    {
        public OkulEntities()
            : base("name=OkulEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DERSLER> DERSLER { get; set; }
        public virtual DbSet<KULUPLER> KULUPLER { get; set; }
        public virtual DbSet<NOTLAR> NOTLAR { get; set; }
        public virtual DbSet<OGRENCILER> OGRENCILER { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}