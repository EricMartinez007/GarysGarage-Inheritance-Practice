namespace Garage;

public class GasStation : IRefuelStation<IGasVehicle>
{
    public int Capacity { get; set; }

    public void Refuel(List<IGasVehicle> vehicles)
    {
        foreach (IGasVehicle vehicle in vehicles)
        {
            // GetType().Name gives the concrete class name ("Ram", "Cessna")
            // even though we only know the vehicle as an IGasVehicle here.
            Console.WriteLine($"The {vehicle.GetType().Name} has been refueled with gas.");
        }
    }
}
