namespace Garage;

public interface IElectricVehicle
{
    double CurrentChargePercentage { get; }
    void ChargeBattery();
}
