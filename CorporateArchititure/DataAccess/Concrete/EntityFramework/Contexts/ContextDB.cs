using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public  class ContextDB:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString:   @"Server=(localdb)\MSSQLLocalDB;
DataBase=BackEndDb;Trusted_Connection=true");

        }
        public DbSet<Product> products { get; set; }
    }
}
