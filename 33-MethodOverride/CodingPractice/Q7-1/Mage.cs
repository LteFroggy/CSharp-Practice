using System;

namespace Q7_1 {
    internal class Mage : Character {
        public Mage(string name, int attackPower) : base(name, attackPower) { }
        public override void Attack() {
            Console.WriteLine($"{Name}이(가) 파이어볼을 시전합니다! 데미지 : {AttackPower}");
        }
    }
}
