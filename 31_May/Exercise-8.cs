using System;
using System.Collections.Generic;
using System.Linq;

// Interface with Print method
public interface IPrintable
{
    void Print();
}

// Abstract Invoice class
public abstract class Invoice : IPrintable
{
    public List<Product> Products { get; set; } = new List<Product>();
    public decimal TaxRate { get; set; }  // e.g. 0.1 for 10%
    public decimal Discount { get; set; } // flat discount amount

    public abstract decimal CalculateTotal();

    public virtual void Print()
    {
        Console.WriteLine("Invoice Details:");
        Console.WriteLine("-----------------------------");
        foreach (var product in Products)
        {
            Console.WriteLine($"{product.Name} - Qty: {product.Quantity} - Price: {product.Price:C} each");
        }
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"Subtotal: {Products.Sum(p => p.Price * p.Quantity):C}");
        Console.WriteLine($"Tax ({TaxRate:P}): {(Products.Sum(p => p.Price * p.Quantity) * TaxRate):C}");
        Console.WriteLine($"Discount: {Discount:C}");
        Console.WriteLine($"Total: {CalculateTotal():C}");
        Console.WriteLine("-----------------------------");
    }
}

public class RetailInvoice : Invoice
{
    public override decimal CalculateTotal()
    {
        decimal subtotal = Products.Sum(p => p.Price * p.Quantity);
        decimal taxAmount = subtotal * TaxRate;
        decimal total = subtotal + taxAmount - Discount;
        return total >= 0 ? total : 0;
    }
}

public class WholesaleInvoice : Invoice
{
    public decimal WholesaleDiscountRate { get; set; }  // e.g. 0.15 for 15% wholesale discount

    public override decimal CalculateTotal()
    {
        decimal subtotal = Products.Sum(p => p.Price * p.Quantity);
        decimal wholesaleDiscount = subtotal * WholesaleDiscountRate;
        decimal taxAmount = (subtotal - wholesaleDiscount) * TaxRate;
        decimal total = subtotal - wholesaleDiscount + taxAmount - Discount;
        return total >= 0 ? total : 0;
    }

    public override void Print()
    {
        Console.WriteLine("Wholesale Invoice Details:");
        Console.WriteLine("-----------------------------");
        base.Print();
        Console.WriteLine($"Wholesale Discount Rate: {WholesaleDiscountRate:P}");
    }
}

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

// Test Program
class Program
{
    static void Main()
    {
        var retailInvoice = new RetailInvoice
        {
            TaxRate = 0.1m,
            Discount = 5,
            Products = new List<Product>
            {
                new Product { Name = "Notebook", Price = 2.5m, Quantity = 10 },
                new Product { Name = "Pen", Price = 1.2m, Quantity = 5 }
            }
        };

        var wholesaleInvoice = new WholesaleInvoice
        {
            TaxRate = 0.1m,
            Discount = 10,
            WholesaleDiscountRate = 0.15m,
            Products = new List<Product>
            {
                new Product { Name = "Printer", Price = 120m, Quantity = 2 },
                new Product { Name = "Monitor", Price = 250m, Quantity = 3 }
            }
        };

        retailInvoice.Print();
        Console.WriteLine();
        wholesaleInvoice.Print();
    }
}
