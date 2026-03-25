using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task07
{
    class PCContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=yand.dyndns.org,14333;Initial Catalog=AdventureWorks;Persist Security Info=True;User ID=northwind;Password=northwind;Encrypt=False;Trust Server Certificate=True");
        }
        public DbSet<ProductCategory> ProductCategories { get; set; }
    }

}

