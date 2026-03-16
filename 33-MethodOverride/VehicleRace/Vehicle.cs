using System;

namespace VehicleRace {
    internal class Vehicle {
        public string Name { get; set; }
        public int Speed { get; set; }
        public Vehicle(string name, int speed) {
            Name = name;
            Speed = speed;
        }
        public virtual void Move() {
            Console.WriteLine($"{Name}이(가) 이동합니다. 속도 : {Speed}km/h");
        }
    }
}
