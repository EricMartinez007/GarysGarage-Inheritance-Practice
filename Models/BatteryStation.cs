namespace Garage;

public class BatteryStation : IRefuelStation<IElectricVehicle>
{
    public int Capacity { get; set; }

    public void Refuel(List<IElectricVehicle> vehicles)
    {
        foreach (IElectricVehicle vehicle in vehicles)
        {
            Console.WriteLine($"The {vehicle.GetType().Name} has been recharged.");
        }
    }
}
