﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataServicesWebApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AdventureWorksLTEntities : DbContext
    {
        public AdventureWorksLTEntities()
            : base("name=AdventureWorksLTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Address1> Address1 { get; set; }
        public DbSet<Customer1> Customer1 { get; set; }
        public DbSet<CustomerAddress1> CustomerAddress1 { get; set; }
        public DbSet<Product1> Product1 { get; set; }
        public DbSet<ProductCategory1> ProductCategory1 { get; set; }
        public DbSet<ProductDescription1> ProductDescription1 { get; set; }
        public DbSet<ProductModel1> ProductModel1 { get; set; }
        public DbSet<ProductModelProductDescription1> ProductModelProductDescription1 { get; set; }
        public DbSet<SalesOrderDetail1> SalesOrderDetail1 { get; set; }
        public DbSet<SalesOrderHeader1> SalesOrderHeader1 { get; set; }
    }
}
