using System;

namespace Q7_1 {
    internal class DamageComponent {
        private int _health;
        public DamageComponent(int health) {
            _health = health;
        }

        public int Health {
            get => _health; 
            set => _health = Math.Clamp(_health+ value, 0, 100);
        }

        public void TakeDamage(int damage) {
            Health -= damage;
        }
    }
}
