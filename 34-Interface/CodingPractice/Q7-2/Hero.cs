using System;

namespace Q7_2 {
    internal class Hero : IAttackable, IMovable {
        public void Attack() {
            Console.WriteLine($"영웅이 공격합니다.");
        }

        public void Move() {
            Console.WriteLine($"영웅이 이동합니다.");
        }
    }
}
