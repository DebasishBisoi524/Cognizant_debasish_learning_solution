using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RetailInventory
{
    public class AppDbContext : DbContext
    {
        private readonly string _connectionString;

        public AppDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

    }
}
