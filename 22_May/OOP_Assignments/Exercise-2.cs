using System;
using System.Collections.Generic;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}

class CartItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public double GetTotalPrice()
    {
        return Product.Price * Quantity;
    }

    public CartItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }
}

class ShoppingCart
{
    public List<CartItem> CartItems { get; set; } = new List<CartItem>();

    public void AddItem(CartItem item)
    {
        CartItems.Add(item);
    }

    public void RemoveItem(CartItem item)
    {
        CartItems.Remove(item);
    }

    public double GetCartTotal()
    {
        double total = 0;
        foreach (var item in CartItems)
        {
            total += item.GetTotalPrice();
        }
        return total;
    }
}

class Program
{
    static void Main()
    {
        Product product1 = new Product(1, "Laptop", 800);
        Product product2 = new Product(2, "Smartphone", 500);

        CartItem cartItem1 = new CartItem(product1, 2);
        CartItem cartItem2 = new CartItem(product2, 1);

        ShoppingCart cart = new ShoppingCart();
        cart.AddItem(cartItem1);
        cart.AddItem(cartItem2);

        Console.WriteLine($"Total Cart Value: ${cart.GetCartTotal()}");
    }
}
