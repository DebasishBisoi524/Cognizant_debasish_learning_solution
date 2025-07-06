// Program.cs
using System;

class Program
{
    static void Main()
    {
        Product[] products = {
            new Product(103, "Smartphone", "Electronics"),
            new Product(101, "Shoes", "Fashion"),
            new Product(105, "Laptop", "Electronics"),
            new Product(102, "T-Shirt", "Fashion"),
            new Product(104, "Refrigerator", "Appliances")
        };

        int targetId = 104;

        Console.WriteLine("=== Linear Search ===");
        Product foundLinear = SearchEngine.LinearSearch(products, targetId);
        Console.WriteLine(foundLinear != null ? foundLinear : "Product not found.");

        Console.WriteLine("\n=== Binary Search ===");
        SearchEngine.SortProductsById(products); // Required for binary search
        Product foundBinary = SearchEngine.BinarySearch(products, targetId);
        Console.WriteLine(foundBinary != null ? foundBinary : "Product not found.");
    }
}
