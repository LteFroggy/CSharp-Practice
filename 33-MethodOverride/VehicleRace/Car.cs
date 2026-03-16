using System;

namespace VehicleRace {
    internal class Car : Vehicle {
        public Car(string name) : base(name, 120) { }
        public override void Move() {
            Console.WriteLine($"{Name}이(가) 도로를 달립니다! 속도 : {Speed}km/h");
        }

    }
}
