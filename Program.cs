using Garage;

Ram truck = new Ram() { MainColor = "blue", MaximumOccupancy = 5, Year = 2021, FuelCapacity = 26.0 };
Tesla modelS = new Tesla() { MainColor = "red", MaximumOccupancy = 5, Year = 2023, BatteryKWh = 100.0 };
Cessna mx410 = new Cessna() { MainColor = "white", MaximumOccupancy = 4, Year = 2019, FuelCapacity = 56.0 };
Zero fxs = new Zero() { MainColor = "black", MaximumOccupancy = 1, Year = 2022, BatteryKWh = 14.4 };

truck.Drive();
truck.Turn("left");
truck.Stop();

modelS.Drive();
modelS.Turn("right");
modelS.Stop();

mx410.Drive();
mx410.Turn("left");
mx410.Stop();

fxs.Drive();
fxs.Turn("right");
fxs.Stop();
