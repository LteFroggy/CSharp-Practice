using System;

namespace Q1_1 {
    internal class Car : ICar {
        public void Go() {
            Console.WriteLine($"자동차가 달립니다.");
        }
    }
}
