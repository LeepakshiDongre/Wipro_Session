using System;

// Step 1: Create the abstract class PaymentGateway
abstract class PaymentGateway
{
    // Abstract method: ProcessPayment, must be implemented by derived classes
    public abstract void ProcessPayment(double amount);

    // Concrete method: ShowGatewayName
    public void ShowGatewayName()
    {
        Console.WriteLine("Processing payment through gateway");
    }
}

// Step 2a: Create derived class StripeGateway
class StripeGateway : PaymentGateway
{
    // Implement the abstract method ProcessPayment for Stripe
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing payment through Stripe: ${amount}");
    }
}

// Step 2b: Create derived class PayPalGateway
class PayPalGateway : PaymentGateway
{
    // Implement the abstract method ProcessPayment for PayPal
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing payment through PayPal: ${amount}");
    }
}

// Step 3: Main method to test the PaymentGateway and derived classes
class Program
{
    static void Main()
    {
        // Step 3a: Create objects of both derived classes using PaymentGateway reference
        PaymentGateway stripePayment = new StripeGateway();
        PaymentGateway paypalPayment = new PayPalGateway();

        // Step 3b: Call ShowGatewayName and ProcessPayment for both objects
        Console.WriteLine("Stripe Payment:");
        stripePayment.ShowGatewayName();
        stripePayment.ProcessPayment(100.50);  // Example amount

        Console.WriteLine("\nPayPal Payment:");
        paypalPayment.ShowGatewayName();
        paypalPayment.ProcessPayment(75.25);   // Example amount
    }
}
