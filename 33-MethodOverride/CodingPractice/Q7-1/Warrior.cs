
using System;

namespace Q7_1 {
    internal class Warrior : Character {
        public Warrior(string name, int attackPower) : base(name, attackPower) { }
        public override void Attack() {
            Console.WriteLine($"{Name}이(가) 칼로 베어냅니다! 데미지 : {AttackPower}");
        }
    }
}
