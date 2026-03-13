using System;

namespace ZooSimulator {
    internal class Elephant: Animal {
        public Elephant(string name, int age) : base(name, age) { }

        public override void MakeSound() {
            Console.WriteLine($"{Name} : 뿌우!");
        }

        public void SprayWater() {
            Console.WriteLine($"{Name}이(가) 물을 뿌립니다.");
        }
    }
}
