using System;

namespace Q4_1 {
    internal class Child : Parent {
        public override void Greet() {
            base.Greet();
            Console.WriteLine($"반갑습니다.");
        }
    }
}
