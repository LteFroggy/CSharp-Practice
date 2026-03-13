using System;

namespace CodingPractice.Q1_2 {
    class Animal {
        public string Name { get; set; }

        public void Eat() {
            Console.WriteLine($"{Name}이(가) 먹이를 먹습니다.");
        }
    }
}
