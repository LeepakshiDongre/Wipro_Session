using System;
using System.Threading.Tasks;

class Program
{
    static async Task DownloadFileAsync(string fileName, int delay)
    {
        await Task.Delay(delay);
        Console.WriteLine($"{fileName} downloaded");
    }

    static async Task Main()
    {
        DateTime startTime = DateTime.Now;

        Task t1 = DownloadFileAsync("File1", 2000);
        Task t2 = DownloadFileAsync("File2", 3000);
        Task t3 = DownloadFileAsync("File3", 1000);

        await Task.WhenAll(t1, t2, t3);

        TimeSpan duration = DateTime.Now - startTime;
        Console.WriteLine($"All downloads completed in {duration.TotalMilliseconds} ms");
    }
}