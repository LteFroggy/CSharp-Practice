using System;

namespace GameCharacter {
    internal class Monster : IAttacker, IDefender {
        public const int k_MaxHp = 30;
        private string _name;
        private int _attackPower = 5;

        private HealthComponent _healthComponent;

        public Monster(HealthComponent healthComponent, string name, int attackPower) {
            _healthComponent = healthComponent;
            _name = name;
            _attackPower = attackPower;
        }
        public int AttackPower => _attackPower;

        public int CurrentHp => _healthComponent.Health;

        public int MaxHp => k_MaxHp;

        public bool isDead => _healthComponent.Health <= 0;

        public string Name => _name;

        public void Attack(IDefender target) {
            if (target.isDead) return;
            target.TakeDamage(_attackPower);
            Console.WriteLine($"{_name}이(가) {target.Name}에게 {_attackPower}데미지! ({target.Name} HP : {target.CurrentHp} / {target.MaxHp})");

            if (target.isDead) {
                Console.WriteLine($"{target.Name}이(가) 쓰러졌습니다!");
            }
        }

        public void TakeDamage(int damage) {
            _healthComponent.TakeDamage(damage);
        }
    }
}
