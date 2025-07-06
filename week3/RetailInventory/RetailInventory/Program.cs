using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace RetailInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load configuration from appsettings.json
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory) // Ensures it finds appsettings.json after build
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var connectionString = config.GetConnectionString("DefaultConnection");

            using var context = new AppDbContext(connectionString);

            try
            {
                // Insert sample data if not already present
                if (!context.Categories.Any())
                {
                    var category = new Category { Name = "Groceries" };
                    var product = new Product
                    {
                        Name = "Rice",
                        Price = 89.99m,
                        Category = category
                    };

                    context.Categories.Add(category);
                    context.Products.Add(product);
                    context.SaveChanges();

                    Console.WriteLine("Sample data inserted!");
                }
                else
                {
                    Console.WriteLine("Data already exists:");
                    foreach (var product in context.Products)
                    {
                        Console.WriteLine($"- {product.Name} (₹{product.Price})");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error: {ex.Message}");
            }
        }
    }
}