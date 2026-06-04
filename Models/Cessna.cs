namespace Garage;

public class Cessna : Vehicle // Propellor light aircraft
{
    public double FuelCapacity { get; set; }
    public void RefuelTank()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Cessna soars overhead. Zooooom!");
    }

    public override void Turn(string direction)
    {
        Console.WriteLine($"The {MainColor} Cessna banks to the {direction}.");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Cessna comes to a stop after rolling a mile down the runway.");
    }
}