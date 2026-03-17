using System;

namespace Q6 {
    internal class Car : Vehicle, IStandard {
        public void Run() {
            Console.WriteLine($"전진");
        }
        public override void Back() {
            Console.WriteLine($"후진");
        }

    }
}
