using ADONETEntityFramework.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADONETEntityFramework
{
    public class EntityContext : DbContext
    {
        public string connectionString;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            connectionString = "Data Source=192.168.50.95;Initial Catalog=sprathipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            optionsBuilder.UseSqlServer(connectionString);
        }

       

        public DbSet<Order> OrdersOfTollplus { get; set; }
        public DbSet<Product> ProductsOfTollplus { get; set; }
    }
}

