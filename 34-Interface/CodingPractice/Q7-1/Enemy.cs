using System;

namespace Q7_1 {
    internal class Enemy : IDamageable {
        private DamageComponent _damageComponent;
        public Enemy(DamageComponent damageComponent) {
            _damageComponent = damageComponent;
        }

        public int Health => _damageComponent.Health;

        public void TakeDamage(int damage) {
            _damageComponent.TakeDamage(damage);
            Console.WriteLine($"적이 {damage} 데미지를 받음. 남은 체력 : {_damageComponent.Health}");
        }
    }
}
