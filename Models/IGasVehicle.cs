namespace Garage;

public interface IGasVehicle
{
    double CurrentTankPercentage { get; }
    void RefuelTank();
}