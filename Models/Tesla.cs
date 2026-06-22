namespace Garage;

public class Tesla : Vehicle, IElectricVehicle  // Electric car
{
    public double BatteryKWh { get; set; }
    public double CurrentChargePercentage { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Tesla glides by silently.");
    }

    public override void Turn(string direction)
    {
        Console.WriteLine($"The {MainColor} Tesla smoothly turns {direction}.");
    }
    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Tesla comes to stop after detecting other cars stopping.");
    }
}