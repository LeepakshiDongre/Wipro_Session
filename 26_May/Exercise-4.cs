using System;

class TempratureSensor
{
    public delegate void OverheatHandler(double temp);
    public event OverheatHandler Overheat;

    public void CheckTemperature(double temp)
    {
        if (temp > 40)
            Overheat?.Invoke(temp);
    }
}
class Program
{
    static void Main()
    {
        var sensor = new TempratureSensor();
        sensor.Overheat += temp => Console.WriteLine($"ALERT: Overheat at {temp} degree Celsius!");

        sensor.CheckTemperature(35);
        sensor.CheckTemperature(42);
    }
}