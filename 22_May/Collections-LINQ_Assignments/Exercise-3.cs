using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
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
            new Product("Laptop", 800),
            new Product("Mouse", 20),
            new Product("Keyboard", 50),
            new Product("Phone", 600),
            new Product("Headphones", 120)
        };

        var filteredProducts = products.Where(p => p.Price > 500).ToList();

        Console.WriteLine("Products with Price > 500:");
        foreach (var product in filteredProducts)
        {
            Console.WriteLine($"{product.Name}: ${product.Price}");
        }
    }
}
