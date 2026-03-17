using System;

namespace Q3_2 {
    internal class Bird : Animal, IFlyable {
        public void Fly() {
            Console.WriteLine($"날아갑니다.");
        }
    }
}
