

using System;
using System.Threading;

class Program
{
    static void ProcessItem(object item)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"Processed: {item}");
    }
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            ThreadPool.QueueUserWorkItem(ProcessItem, $"Item {i}");
        }
        Thread.Sleep(2000);  // wait for all tasks
    }
}