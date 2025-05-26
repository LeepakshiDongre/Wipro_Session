using System;

interface IPaymentStrategy
{
    void Pay(double amount);
}

class CreditCardPayment : IPaymentStrategy
{
    public void Pay(double amount) => Console.WriteLine($"Paid  {amount} with credit card");
}
class PayPalPayment : IPaymentStrategy
{
    public void Pay(double amount) => Console.WriteLine($"Paid  {amount} with PayPal");
}
class PaymentContext
{
    private IPaymentStrategy _strategy;
    public PaymentContext(IPaymentStrategy strategy) => _strategy = strategy;
    public void ExecutePayment(double amount) => _strategy.Pay(amount);

}
class Program
{
    static void Main()
    {

        var creditCard = new PaymentContext(new CreditCardPayment());
        creditCard.ExecutePayment(500);

        var paypal = new PaymentContext(new PayPalPayment());
        paypal.ExecutePayment(1200);

    }

}