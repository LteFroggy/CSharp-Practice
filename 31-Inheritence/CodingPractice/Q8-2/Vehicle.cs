using System;

namespace CodingPractice.Q8_2 {
    abstract internal class Vehicle {
        public abstract void Start();

        public void Stop() {
            Console.WriteLine($"정지합니다.");
        }
    }
}
