namespace Garage;

public class Ram : Vehicle  // Gas powered truck
{
    public double FuelCapacity { get; set; }
    public void RefuelTank()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram drives past. RRrrrrrummbbble!");
    }

    public override void Turn(string direction)
    {
        Console.WriteLine($"The {MainColor} Ram cuts hard {direction} and turns on two wheels.");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Ram rumbles to a stop.");
    }
}