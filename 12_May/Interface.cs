
interface IShape
{
    void Draw();

}

class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle();
        circle.Draw();
    }
}



// CREDIT CARD PAYMENT
interface Ipayment
{
    void ProcessPayment(decimal amount);
}

//Implementing the interface in CreditCardPayment

class CreditCardPayment : Ipayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount}");

    }
}
//Implementing the interface in PayPalPayment
class PayPalPayment : Ipayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of {amount}");
    }
}

class Program
{
    static void Main()
    {
        // Using theinterface as a reference 
        Ipayment payment;

        //Creadit card Payment
        payment = new CreditCardPayment();
        payment.ProcessPayment(1500.50m);

        //PayPal payment
        payment = new PayPalPayment();
        payment.ProcessPayment(2500.75m);
    }
}