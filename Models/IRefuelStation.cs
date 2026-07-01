namespace Garage;

// Generic interface: T is a placeholder for the kind of vehicle a station handles.
// GasStation fills T with IGasVehicle, BatteryStation fills it with IElectricVehicle.
public interface IRefuelStation<T>
{
    int Capacity { get; set; }
    void Refuel(List<T> vehicles);
}
