using System;

namespace VehicleRace {
    internal class Airplane : Vehicle {
        public Airplane(string name) : base(name, 900) { }
        public override void Move() {
            Console.WriteLine($"{Name}이(가) 하늘을 납니다! 속도 : {Speed}km/h");
        }
    }
}
