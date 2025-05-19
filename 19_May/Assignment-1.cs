using System;

interface IRemoteControl
{
    void IncreaseVolume();
    void DecreaseVolume();
}
abstract class SmartDevice
{
    public abstract void TurnOn();

    public void ShowStatus()
    {
        Console.WriteLine("Device status: Active");
    }
}
class SmartLight : SmartDevice, IRemoteControl
{
    public override void TurnOn()
    {
        Console.WriteLine("Smart Light turned on");
    }
    public void IncreaseVolume()
    {
        Console.WriteLine("Light do not support volume control");
    }
    public void DecreaseVolume()
    {
        Console.WriteLine("Light do not support volume control");
    }

}
class SmartSpeaker : SmartDevice, IRemoteControl
{
    public override void TurnOn()
    {
        Console.WriteLine("Smart Speaker turned on");
    }
    public void IncreaseVolume()
    {
        Console.WriteLine("Volume Increased");
    }
    public void DecreaseVolume()
    {
        Console.WriteLine("Volume Decreased");
    }

}
class Program
{
    static void Main()
    {
        SmartDevice light  = new SmartLight();
        SmartDevice speaker = new SmartSpeaker();

        Console.WriteLine("=== Smart Light ===");
        light.ShowStatus();
        light.TurnOn();
        ((IRemoteControl)light).IncreaseVolume();
        ((IRemoteControl)light).DecreaseVolume();

        Console.WriteLine("\n=== Smart Speaker ===");
        speaker.ShowStatus();
        speaker.TurnOn();
        ((IRemoteControl)speaker).IncreaseVolume();
        ((IRemoteControl)speaker).DecreaseVolume();

    }
}