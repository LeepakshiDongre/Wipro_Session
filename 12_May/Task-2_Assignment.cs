using System;


interface IDeviceControl
{
    void TurnOn();
    void TurnOff();
}
class SmartTV : IDeviceControl
{
    public void TurnOn()
    {
        Console.WriteLine("SmartTV is now ON");
    }
    public void TurnOff()
    {
        Console.WriteLine("SmartTV is now OFF");
    }
}
class Speaker : IDeviceControl
{
    public void TurnOn()
    {
        Console.WriteLine("Speaker is now ON");
    }
    public void TurnOff()
    {
        Console.WriteLine("Speaker is now OFF");
    }
}
 class Program
{
    static void Main()
    {
        IDeviceControl tv = new Speaker();
        IDeviceControl speaker = new Speaker();

        tv.TurnOn();
        tv.TurnOff();

        speaker.TurnOn();
        speaker.TurnOff();
    }
}