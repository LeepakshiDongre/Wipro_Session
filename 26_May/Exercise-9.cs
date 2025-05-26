using System;

class Logger
{
    private static Logger _instance;
    private static readonly object _lock = new();

    private Logger() { }

    public static Logger Instance
    {
        get
        {
            lock (_lock)
            {
                return _instance ??= new Logger();
            }
        }
    }

    public void Log(string message) => Console.WriteLine($"Log: {message}");
}

class Program
{
    static void Main()
    {
        Logger.Instance.Log("Application Started");
    }
}