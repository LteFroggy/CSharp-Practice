using System;

namespace CodingPractice.Q12 {
    internal class Warrior : GameCharacter {
        public int AttackDamage;
        public Warrior(string name, int health, int attack) : base(name, health) { 
            AttackDamage = attack;
        }

        public override void Attack() {
            Console.WriteLine($"{Name}이(가) 검으로 {AttackDamage} 데미지를 입힙니다!");
        }
    }
}
