﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KnowledgeBase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KnowledgeBaseEntities : DbContext
    {
        public KnowledgeBaseEntities()
            : base("name=KnowledgeBaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Keyword> Keywords { get; set; }
        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<Developer> Developers { get; set; }
        public virtual DbSet<SolvedReport> SolvedReports { get; set; }
        public virtual DbSet<UnverifiedReport> UnverifiedReports { get; set; }
        public virtual DbSet<VerifiedReport> VerifiedReports { get; set; }
    }
}
