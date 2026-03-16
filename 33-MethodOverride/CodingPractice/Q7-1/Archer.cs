using System;

namespace Q7_1 {
    internal class Archer : Character {
        public Archer(string name, int attackPower) : base(name, attackPower) { }
        public override void Attack() {
            Console.WriteLine($"{Name}이(가) 화살을 쏩니다! 데미지 : {AttackPower}");
        }
    }
}
