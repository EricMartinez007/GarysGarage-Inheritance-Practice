namespace Garage;

public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
{
    public double BatteryKWh { get; set; }
    public double CurrentChargePercentage { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Zero zips by. Whirrrr!");
    }

    public override void Turn(string direction)
    {
        Console.WriteLine($"The {MainColor} Zero leans hard and cuts {direction}.");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Zero leans back and skids to a stop.");
    }
}