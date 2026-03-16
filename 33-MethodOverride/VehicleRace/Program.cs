using System;
using VehicleRace;

Vehicle[] vehicles =  new Vehicle[] {
    new Car("스포츠카"),
    new Airplane("보잉747"),
    new Boat("요트")
};

foreach (var vehicle in vehicles) {
    vehicle.Move();
}
Console.WriteLine();
Console.WriteLine();
