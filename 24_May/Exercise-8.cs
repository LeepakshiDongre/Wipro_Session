using System;
using System.Threading.Tasks;

class Program
{
    static async Task RiskyTaskAsync(string name)
    {
        await Task.Delay(1000);
        if (name == "Task 2")
            throw new Exception($"{name} failed");

        Console.WriteLine($"{name} completed");
    }

    static async Task Main()
    {
        var tasks = new[]
        {
            RiskyTaskAsync("Task 1"),
            RiskyTaskAsync("Task 2"),
            RiskyTaskAsync("Task 3")
        };

        try
        {
            await Task.WhenAll(tasks);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
    }
}