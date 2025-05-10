using System;

// Base class Payment
class Payment
{
    public decimal Amount { get; set; }
    public string Currency { get; set; }

    // Method to process payment
    public virtual void ProcessPayment()
    {
        Console.WriteLine($"Processing payment of {Amount} {Currency}");
    }
}

// Derived class CreditCardPayment
class CreditCardPayment : Payment
{
    public string CardNumber { get; set; }

    // Override the ProcessPayment method to include card number
    public override void ProcessPayment()
    {
        Console.WriteLine($"Processing Credit Card Payment of {Amount} {Currency} with card number {CardNumber}");
    }
}

// Derived class PayPalPayment
class PayPalPayment : Payment
{
    // Overloaded ProcessPayment method that accepts only amount
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal Payment of {amount} using default currency USD");
    }

    // Overloaded ProcessPayment method that accepts both amount and currency
    public void ProcessPayment(decimal amount, string currency)
    {
        Console.WriteLine($"Processing PayPal Payment of {amount} {currency}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating objects of CreditCardPayment and PayPalPayment
        CreditCardPayment creditCard = new CreditCardPayment()
        {
            Amount = 100.50m,
            Currency = "USD",
            CardNumber = "1234-5678-9876-5432"
        };

        PayPalPayment paypal = new PayPalPayment();

        // Demonstrating method overloading and inheritance

        // Calling overridden ProcessPayment() for CreditCardPayment
        creditCard.ProcessPayment();  // Output: Processing Credit Card Payment of 100.5 USD with card number 1234-5678-9876-5432

        // Calling overloaded ProcessPayment() for PayPalPayment
        paypal.ProcessPayment(50.75m);  // Output: Processing PayPal Payment of 50.75 using default currency USD
        paypal.ProcessPayment(75.40m, "EUR");  // Output: Processing PayPal Payment of 75.4 EUR
    }
}
