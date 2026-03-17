using System;

namespace Q1_3 {
    internal class Person : IPerson {
        public void Rest() {
            Console.WriteLine($"일을 합니다.");
        }

        public void Work() {
            Console.WriteLine($"휴식을 취합니다.");
        }
    }
}
