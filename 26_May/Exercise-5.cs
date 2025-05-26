using System;
using System.Threading.Tasks;

class Program
{
    static async Task<string> GetDataAsync()
    {
        await Task.Delay(1000);   // Simulate delay like file/network read 
        return "Simulated file content: Hello from async method!";
    }

    static async Task Main()
    {
        Console.WriteLine("Fetching data asynchronously...");

        string content = await GetDataAsync();

        Console.WriteLine("Content received:");
        Console.WriteLine(content);
    }
}