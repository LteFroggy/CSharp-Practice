using System;

namespace ZooSimulator {
    internal class Lion: Animal {
        public Lion(string name, int age) : base(name, age) {

        }

        public override void MakeSound() {
            Console.WriteLine($"{Name} : 으르렁!");
        }

        public void Hunt() {
            Console.WriteLine($"{Name}이(가) 사냥을 합니다.");
        }
    }
}
