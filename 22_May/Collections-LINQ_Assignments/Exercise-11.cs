using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product(1, "Laptop", 800),
            new Product(2, "Mouse", 20),
            new Product(3, "Keyboard", 50),
            new Product(4, "Phone", 600),
            new Product(5, "Headphones", 120)
        };

        var sortedProducts = products.OrderByDescending(p => p.Price).ToList();

        Console.WriteLine("Sorted Products by Price (Descending):");
        foreach (var product in sortedProducts)
        {
            Console.WriteLine($"{product.Name}: ${product.Price}");
        }
    }
}
