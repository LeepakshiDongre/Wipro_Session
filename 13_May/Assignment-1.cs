using System;

// Step 1: Create the ITransport interface
interface ITransport
{
    void Start();
    void Stop();
}

// Step 2a: Implement the interface in Bus class
class Bus : ITransport
{
    public void Start()
    {
        Console.WriteLine("Bus is starting");
    }

    public void Stop()
    {
        Console.WriteLine("Bus is stopping");
    }
}

// Step 2b: Implement the interface in Train class
class Train : ITransport
{
    public void Start()
    {
        Console.WriteLine("Train is starting");
    }

    public void Stop()
    {
        Console.WriteLine("Train is stopping");
    }
}

// Step 3: Main method to test the interface
class Program
{
    static void Main()
    {
        // Step 3a: Create objects using ITransport reference
        ITransport bus = new Bus();
        ITransport train = new Train();

        // Step 3b: Call Start and Stop for each object
        Console.WriteLine("Bus operations:");
        bus.Start();
        bus.Stop();

        Console.WriteLine("\nTrain operations:");
        train.Start();
        train.Stop();
    }
}
