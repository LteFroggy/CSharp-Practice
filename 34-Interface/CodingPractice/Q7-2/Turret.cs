using System;

namespace Q7_2 {
    internal class Turret : IAttackable {
        public void Attack() {
            Console.WriteLine($"포탑이 발사합니다.");
        }
    }
}
