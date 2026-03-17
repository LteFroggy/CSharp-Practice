using System;

namespace Q7_1 {
    internal class Building : IDamageable {
        private DamageComponent _damageComponent;

        public Building(DamageComponent damageComponent) {
            _damageComponent = damageComponent;
        }

        public int Health => _damageComponent.Health;

        public void TakeDamage(int damage) {
            _damageComponent.TakeDamage(damage);
            Console.WriteLine($"건물이 {damage}데미지를 받음. 남은 내구도 : {_damageComponent.Health}");
        }
    }
}
