using System;
using System.Threading;

class Program
{
    private static object lockObj = new object();
    private static int totalLines = 0;

    // Simulated "files" as arrays of strings
    static string[][] simulatedFiles = new string[][]
    {
        new string[] { "Line1", "Line2", "Line3", "Line4" },            // Simulated file1
        new string[] { "Line1", "Line2", "Line3" },                     // Simulated file2
        new string[] { "Line1", "Line2", "Line3", "Line4", "Line5" }   // Simulated file3
    };

    public static void ProcessFile(int fileIndex)
    {
        int lineCount = simulatedFiles[fileIndex].Length;

        // Simulate processing delay (optional)
        Thread.Sleep(100);

        lock (lockObj)
        {
            totalLines += lineCount;
        }

        Console.WriteLine($"Simulated File {fileIndex + 1} processed with {lineCount} lines.");
    }

    static void Main()
    {
        int numberOfFiles = simulatedFiles.Length;
        Thread[] threads = new Thread[numberOfFiles];

        for (int i = 0; i < numberOfFiles; i++)
        {
            int index = i; // Capture loop variable
            threads[i] = new Thread(() => ProcessFile(index));
            threads[i].Start();
        }

        // Wait for all threads to complete
        foreach (var thread in threads)
        {
            thread.Join();
        }

        Console.WriteLine($"Total lines across all simulated files: {totalLines}");
    }
}
