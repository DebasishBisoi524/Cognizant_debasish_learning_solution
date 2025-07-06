// SearchEngine.cs
using System;

public static class SearchEngine
{
    // Linear Search
    public static Product LinearSearch(Product[] products, int targetId)
    {
        foreach (var product in products)
        {
            if (product.ProductId == targetId)
                return product;
        }
        return null;
    }

    // Binary Search (requires sorted products)
    public static Product BinarySearch(Product[] products, int targetId)
    {
        int left = 0, right = products.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (products[mid].ProductId == targetId)
                return products[mid];
            else if (products[mid].ProductId < targetId)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return null;
    }

    // Helper method to sort products by ProductId
    public static void SortProductsById(Product[] products)
    {
        Array.Sort(products, (a, b) => a.ProductId.CompareTo(b.ProductId));
    }
}
