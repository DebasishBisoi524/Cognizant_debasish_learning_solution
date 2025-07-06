using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailInventory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using var context = new RetailDbContext();

            // Check if data already exists
            if (!context.Categories.Any())
            {
                var category = new Category { Name = "Electronics" };
                var product = new Product { Name = "Laptop", Stock = 15, Category = category };

                context.Categories.Add(category);
                context.Products.Add(product);
                context.SaveChanges();

                Console.WriteLine("Sample data inserted successfully!");
            }
            else
            {
                Console.WriteLine("Data already exists:");
                foreach (var product in context.Products)
                {
                    Console.WriteLine($"- {product.Name} ({product.Stock} in stock)");
                }
            }
        }
    }
}
