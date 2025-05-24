using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task DoWorkAsync(CancellationToken token)
    {
        for (int i = 0; i < 10; i++)
        {
            token.ThrowIfCancellationRequested();
            Console.WriteLine($"Working... {i}");
            await Task.Delay(500);
        }
    }

    static async Task Main()
    {
        CancellationTokenSource cts = new CancellationTokenSource();

        var task = DoWorkAsync(cts.Token);

        await Task.Delay(2000);
        cts.Cancel();

        try
        {
            await task;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Task was cancelled.");
        }
    }
}