using System;

namespace CodingPractice.Q6_1 {
    internal class Animal {
        public string Name { get; set; }
        public void Eat() {
            Console.WriteLine($"{Name}이(가) 먹습니다.");
        }
    }
}
