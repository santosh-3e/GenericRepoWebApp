﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace GenericRepoWebApp.Data.DataAccess.SqlServer
{
    public partial class FooBarEntities1 : DbContext
    {
        public FooBarEntities1()
            : base("name=FooBarEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Bar> Bars { get; set; }
        public DbSet<Foo> Foos { get; set; }
    }
}
