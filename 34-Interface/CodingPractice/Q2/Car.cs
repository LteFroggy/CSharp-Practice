using System;

namespace Q2 {
    internal class Car {
        private IBattery _battery;
        public Car(IBattery battery) {
            _battery = battery;
        }

        public void Run() {
            Console.WriteLine($"{_battery.GetName()}을 장착한 자동차가 달립니다.");
        }
    }
}
