using System;

namespace CodingPractice.Q6_1 {
    internal class Dog : Animal {
        public void Bark() {
            Console.WriteLine($"{Name}이(가) 짖습니다");
        }
    }
}
