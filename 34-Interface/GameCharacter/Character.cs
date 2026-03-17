using System;
using System.Security.Cryptography.X509Certificates;

namespace GameCharacter {
    internal class Character : IAttacker, IDefender {
        public const int k_MaxHp = 100;

        private string _name;
        private int _attackPower = 20;
        private HealthComponent _healthComponent;

        public Character(HealthComponent healthComponent, string name) {
            _healthComponent = healthComponent;
            _name = name;
        }
        public string Name => _name;

        public int AttackPower => _attackPower;

        public int CurrentHp => _healthComponent.Health;

        public int MaxHp => k_MaxHp;

        public bool isDead => _healthComponent.Health <= 0;

        public void Attack(IDefender target) {
            if (target.isDead) return;
            Console.WriteLine($"{_name}이(가) {target.Name}에게 {_attackPower}데미지! ({target.Name} HP : {target.CurrentHp} / {target.MaxHp})");
            target.TakeDamage(_attackPower);

            if (target.isDead) {
                Console.WriteLine($"{target.Name}이(가) 쓰러졌습니다!");
            }
        }

        public void TakeDamage(int damage) {
            _healthComponent.TakeDamage(damage);
        }
    }
}
