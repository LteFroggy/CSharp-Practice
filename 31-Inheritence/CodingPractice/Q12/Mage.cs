using System;

namespace CodingPractice.Q12 {
    internal class Mage : GameCharacter {
        public int MagicDamage;
        public Mage(string name, int health, int magicDamage) : base(name, health) {
            MagicDamage = magicDamage;
        }

        public override void Attack() {
            Console.WriteLine($"{Name}이(가) 마법으로 {MagicDamage} 데미지를 입힙니다!");
        }
    }
}
