using System;

namespace Q7_1 {
    internal class Character {
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public Character(string name, int attackPower) {
            Name = name;
            AttackPower = attackPower;
        }
        public virtual void Attack() {
            Console.WriteLine("공격!");

        }
     
        public virtual void PrintInfo() {
            Console.WriteLine($"[{Name}] 공격력 : {AttackPower}");
        }
    }
}
