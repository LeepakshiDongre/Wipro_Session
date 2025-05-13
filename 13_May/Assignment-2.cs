using System;

// Step 1: Create the IOrder interface
interface IOrder
{
    void PlaceOrder(string item);
    void CancelOrder(string item);
}

// Step 2a: Implement the interface in DineInOrder class
class DineInOrder : IOrder
{
    public void PlaceOrder(string item)
    {
        Console.WriteLine($"Placing dine-in order for {item}");
    }

    public void CancelOrder(string item)
    {
        Console.WriteLine($"Cancelling dine-in order for {item}");
    }
}

// Step 2b: Implement the interface in TakeawayOrder class
class TakeawayOrder : IOrder
{
    public void PlaceOrder(string item)
    {
        Console.WriteLine($"Placing takeaway order for {item}");
    }

    public void CancelOrder(string item)
    {
        Console.WriteLine($"Cancelling takeaway order for {item}");
    }
}

// Step 3: Main method to test the interface
class Program
{
    static void Main()
    {
        // Step 3a: Create objects using IOrder reference
        IOrder dineInOrder = new DineInOrder();
        IOrder takeawayOrder = new TakeawayOrder();

        // Step 3b: Call PlaceOrder and CancelOrder for each object
        Console.WriteLine("Dine-In Order Operations:");
        dineInOrder.PlaceOrder("Pizza");
        dineInOrder.CancelOrder("Pizza");

        Console.WriteLine("\nTakeaway Order Operations:");
        takeawayOrder.PlaceOrder("Burger");
        takeawayOrder.CancelOrder("Burger");
    }
}
