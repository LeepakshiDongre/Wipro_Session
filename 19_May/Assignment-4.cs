using System;

abstract class PaymentMethod
{
    public abstract void ProcessPayment(decimal amount);

    public virtual void ShowPaymentMethod()
    {
        Console.WriteLine("Payment Method: [Method]");
    }
}

class CreditCardPayment : PaymentMethod
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of ₹{amount}");
    }

    public override void ShowPaymentMethod()
    {
        Console.WriteLine("Payment Method: Credit Card");
    }
}

class UPIPayment : PaymentMethod
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing UPI payment of ₹{amount}");
    }

    public override void ShowPaymentMethod()
    {
        Console.WriteLine("Payment Method: UPI");
    }
}

class Program
{
    static void Main()
    {
        PaymentMethod payment1 = new CreditCardPayment();
        PaymentMethod payment2 = new UPIPayment();

        payment1.ShowPaymentMethod();
        payment1.ProcessPayment(500.00m);

        Console.WriteLine();

        payment2.ShowPaymentMethod();
        payment2.ProcessPayment(250.00m);
    }
}