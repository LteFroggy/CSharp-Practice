using System;

namespace Q6 {
    abstract internal class Vehicle {
        public abstract void Back();
        public void Left() {
            Console.WriteLine($"좌회전");
        }
    }
}
