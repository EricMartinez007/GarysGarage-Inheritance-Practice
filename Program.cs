using Garage;

Zero fxs = new Zero() { MainColor = "black", MaximumOccupancy = 1, Year = 2022, BatteryKWh = 14.4 };
Zero fx = new Zero() { MainColor = "green", MaximumOccupancy = 1, Year = 2024, BatteryKWh = 18.5 };
Tesla modelS = new Tesla() { MainColor = "red", MaximumOccupancy = 5, Year = 2023, BatteryKWh = 100.0 };

List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
    fx, fxs, modelS
};

Console.WriteLine("Electric Vehicles");
foreach(IElectricVehicle ev in electricVehicles)
{
    Console.WriteLine($"{ev.CurrentChargePercentage}");
}

foreach(IElectricVehicle ev in electricVehicles)
{
    // This should charge the vehicle to 100%
    ev.ChargeBattery();
}

foreach(IElectricVehicle ev in electricVehicles)
{
    Console.WriteLine($"{ev.CurrentChargePercentage}");
}

/***********************************************/

Ram truck = new Ram() { MainColor = "blue", MaximumOccupancy = 5, Year = 2021, FuelCapacity = 26.0 };
Cessna mx410 = new Cessna() { MainColor = "white", MaximumOccupancy = 4, Year = 2019, FuelCapacity = 56.0 };

List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
    truck, mx410
};

Console.WriteLine("Gas Vehicles");
foreach(IGasVehicle gv in gasVehicles)
{
    Console.WriteLine($"{gv.CurrentTankPercentage}");
}

foreach(IGasVehicle gv in gasVehicles)
{
    // This should completely refuel the gas tank
    gv.RefuelTank();
}

foreach(IGasVehicle gv in gasVehicles)
{
    Console.WriteLine($"{gv.CurrentTankPercentage}");
}

/***********************************************/

Console.WriteLine("Refueling Stations");

BatteryStation batteryStation = new BatteryStation() { Capacity = 4 };
GasStation gasStation = new GasStation() { Capacity = 2 };

// Each station only accepts the list type it was built for. Try passing
// gasVehicles to batteryStation.Refuel() and the compiler will reject it.
batteryStation.Refuel(electricVehicles);
gasStation.Refuel(gasVehicles);