using System;

namespace Q4_1 {
    internal class Pet : ICat, IDog {
        void IDog.Eat() {
            Console.WriteLine($"개처럼 먹습니다.");
        }

        void ICat.Eat() {
            Console.WriteLine($"고양이처럼 먹습니다.");
        }
    }
}
