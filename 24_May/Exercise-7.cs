using System;
using System.Threading.Tasks;

class Program
{
    static async Task<string> DoWorkAsync(string name, int delay)
    {
        await Task.Delay(delay);
        return name;
    }

    static async Task Main()
    {
        var t1 = DoWorkAsync("Task 1", 3000);
        var t2 = DoWorkAsync("Task 2", 1000);
        var t3 = DoWorkAsync("Task 3", 2000);

        var firstFinished = await Task.WhenAny(t1, t2, t3);
        Console.WriteLine($"First completed: {firstFinished.Result}");
    }
}