using System;
using System.Threading;

class Program
{
    static void Countdown()
    {
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
        Console.WriteLine("Done!");

    }
    static void Main()
    {
        Thread t = new Thread(Countdown);
        t.Start();
    }

}