using System;
using System.Threading.Tasks;

class Program
{
    static bool pause = false;
    static bool stop = false;

    static void CountNumbers()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (stop) break;

            while (pause)
            {
                Thread.Sleep(100);  // wait while paused

            }

            Console.WriteLine($"Number: {i}");
            Thread.Sleep(200);  // simulate work
        }

        Console.WriteLine("Thread completed or stopped.");
    }
    static void Main()
    {
        Thread t = new Thread(CountNumbers);
        t.Start();

        Thread.Sleep(2000);  // Let it run a bit
        pause = true;
        Console.WriteLine("Thread paused.");
        Thread.Sleep(2000);

        pause = false;
        Console.WriteLine("Thread resumed.");
        Thread.Sleep(2000);

        stop = true;
        Console.WriteLine("Thread stopping...");

        t.Join();
        Console.WriteLine($"Final Thread State: {t.ThreadState}");

    }
}
