using System;

namespace CodingPractice.Q12 {
    abstract internal class GameCharacter {
        public string Name;
        public int Health;

        protected GameCharacter(string name, int health) {
            Name = name;
            Health = health;
        }

        public abstract void Attack();
        public void ShowStatus() {
            Console.WriteLine($"[{Name}] 체력 : {Health}");
        }
    }
}
