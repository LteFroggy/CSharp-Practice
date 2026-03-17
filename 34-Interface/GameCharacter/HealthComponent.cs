using System;

namespace GameCharacter {
    internal class HealthComponent {
        public int Health {get; private set; }
        public HealthComponent(int health) {
            Health = health;
        }
        public int TakeDamage(int amount) {
            Health = Math.Clamp(Health - amount, 0, 100);
            return Health;
        }
    }
}
