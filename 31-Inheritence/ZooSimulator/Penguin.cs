using System;

namespace ZooSimulator {
    internal class Penguin: Animal {
        public Penguin(string name, int age) : base(name, age) {
        }

        public override void MakeSound() {
            Console.WriteLine($"{Name} : 꽥꽥!");
        }

        public void Swim() {
            Console.WriteLine($"{Name}이(가) 수영을 합니다.");
        }
    }
}
