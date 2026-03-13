using System;

namespace CodingPractice.Q8_2 {
    internal class Car: Vehicle {
        public override void Start() {
            Console.WriteLine($"자동차 시동을 켭니다");
        }
    }
}
