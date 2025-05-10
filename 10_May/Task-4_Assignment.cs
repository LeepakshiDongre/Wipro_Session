using System;

// Base class SmartDevice
class SmartDevice
{
    public string DeviceName { get; set; }
    public bool PowerStatus { get; set; }

    // Constructor for SmartDevice
    public SmartDevice(string deviceName)
    {
        DeviceName = deviceName;
        PowerStatus = false; // Power is initially off
    }

    // Method to toggle the power status
    public void TogglePower()
    {
        PowerStatus = !PowerStatus; // Toggle power status
        string status = PowerStatus ? "on" : "off";
        Console.WriteLine($"{DeviceName} is now {status}");
    }

    // Method to print device status
    public void PrintStatus()
    {
        string status = PowerStatus ? "on" : "off";
        Console.WriteLine($"{DeviceName} Status: Power is {status}");
    }
}

// Derived class SmartLight
class SmartLight : SmartDevice
{
    public int Brightness { get; set; }

    // Constructor for SmartLight
    public SmartLight(string deviceName, int brightness) : base(deviceName)
    {
        Brightness = brightness;
    }

    // Method to adjust brightness
    public void AdjustBrightness(int newBrightness)
    {
        Brightness = newBrightness;
        Console.WriteLine($"{DeviceName} brightness is set to {Brightness}%");
    }
}

// Derived class SmartThermostat
class SmartThermostat : SmartDevice
{
    public double Temperature { get; set; }

    // Constructor for SmartThermostat
    public SmartThermostat(string deviceName, double temperature) : base(deviceName)
    {
        Temperature = temperature;
    }

    // Method to adjust temperature
    public void AdjustTemperature(double newTemperature)
    {
        Temperature = newTemperature;
        Console.WriteLine($"{DeviceName} temperature is set to {Temperature}°C");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of SmartLight and SmartThermostat
        SmartLight livingRoomLight = new SmartLight("Living Room Light", 50); // Initial brightness 50%
        SmartThermostat homeThermostat = new SmartThermostat("Home Thermostat", 22.0); // Initial temperature 22°C

        // Test the SmartLight
        livingRoomLight.TogglePower();  // Turn on the light
        livingRoomLight.AdjustBrightness(75);  // Adjust brightness to 75%
        livingRoomLight.PrintStatus();  // Print status of the light

        // Test the SmartThermostat
        homeThermostat.TogglePower();  // Turn on the thermostat
        homeThermostat.AdjustTemperature(21.5);  // Adjust temperature to 21.5°C
        homeThermostat.PrintStatus();  // Print status of the thermostat
    }
}
