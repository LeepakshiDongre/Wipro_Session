using System;

class Program
{
    static void Main()

    {
        string simulatedFile = ""; //   Simulated in-memory "file"

        // Simulate writing to the file
        simulatedFile = "Log Entry: " + DateTime.Now;

        // Simulate reading from the file
        string content = simulatedFile;

        Console.WriteLine("Log File Content:\n" + content);

    }

    
}