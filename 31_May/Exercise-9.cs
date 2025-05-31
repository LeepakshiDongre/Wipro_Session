using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string[] cities = { "New York", "London", "Tokyo" };

        Console.WriteLine("Fetching weather data for cities...\n");

        var startTime = DateTime.Now;

        // Start all fetch tasks concurrently
        Task<string>[] fetchTasks = new Task<string>[cities.Length];
        for (int i = 0; i < cities.Length; i++)
        {
            fetchTasks[i] = FetchWeatherAsync(cities[i]);
        }

        // Wait for all to complete
        string[] results = await Task.WhenAll(fetchTasks);

        var endTime = DateTime.Now;
        var elapsed = endTime - startTime;

        // Display results
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }

        Console.WriteLine($"\nTotal time taken: {elapsed.TotalMilliseconds} ms");
    }

    static async Task<string> FetchWeatherAsync(string city)
    {
        // Simulate API call delay (random between 1-3 seconds)
        Random rnd = new Random();
        int delay = rnd.Next(1000, 3000);
        await Task.Delay(delay);

        // Simulated temperature data
        int temp = rnd.Next(-10, 40);

        return $"Weather in {city}: {temp}°C (fetched in {delay} ms)";
    }
}
