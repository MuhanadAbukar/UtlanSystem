﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EFModel : DbContext
    {
        public EFModel()
            : base("name=EFModel")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Active> Actives { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Email> Emails { get; set; }
    }
}
