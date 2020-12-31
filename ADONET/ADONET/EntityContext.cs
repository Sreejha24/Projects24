using ADONETEntityFramework.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADONET
{
    public class EntityContext : DbContext
    {
        public string connectionString;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            connectionString = "Data Source=192.168.50.95;Initial Catalog=sprathipati;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            optionsBuilder.UseSqlServer(connectionString);
        }
        public Microsoft.EntityFrameworkCore.DbSet<Order> Orderss { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Product> Productss { get; set; }
    }
}
