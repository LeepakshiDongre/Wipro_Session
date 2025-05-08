using System;
using System.Collections.Generic;

class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}

class Program
{
    static void Main()
    {
        // 1. Create a List<Product>
        List<Product> products = new List<Product>();

        // 2. Add 5 products
        products.Add(new Product { ID = 1, Name = "Laptop", Price = 950.00 });
        products.Add(new Product { ID = 2, Name = "Smartphone", Price = 600.00 });
        products.Add(new Product { ID = 3, Name = "Tablet", Price = 300.00 });
        products.Add(new Product { ID = 4, Name = "Monitor", Price = 200.00 });
        products.Add(new Product { ID = 5, Name = "Headphones", Price = 150.00 });

        // 3. Sort by price in descending order
        products.Sort((p1, p2) => p2.Price.CompareTo(p1.Price));

        // 4. Print the product with the highest price
        Product highestPricedProduct = products[0];
        Console.WriteLine("Product with the highest price:");
        Console.WriteLine($"ID: {highestPricedProduct.ID}, Name: {highestPricedProduct.Name}, Price: {highestPricedProduct.Price:C}");

        // Optional: Print all products
        Console.WriteLine("\nAll products (sorted by price descending):");
        foreach (var product in products)
        {
            Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Price: {product.Price:C}");
        }
    }
}
