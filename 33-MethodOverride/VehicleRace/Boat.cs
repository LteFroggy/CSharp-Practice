using System;

namespace VehicleRace {
    internal class Boat : Vehicle {
        public Boat(string name) : base(name, 60) { }

        public override void Move() {
            Console.WriteLine($"{Name}이(가) 바다를 항해합니다! 속도 : {Speed}km/h");
        }
    }
}
