using System;
using System.Threading.Tasks;

class Program
{
    static async Task<int> GetTemperatureAsync(string city)
    {
        await Task.Delay(1000);
        return new Random().Next(-10, 40);
    }

    static async Task Main()
    {
        var temp1 = await GetTemperatureAsync("Mumbai");
        var temp2 = await GetTemperatureAsync("Delhi");
        var temp3 = await GetTemperatureAsync("London");

        Console.WriteLine($"Mumbai: {temp1}°C, Delhi: {temp2}°C, London: {temp3}°C");
    }
}