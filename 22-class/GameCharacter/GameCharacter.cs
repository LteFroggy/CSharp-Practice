using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace GameCharacter {
    internal class GameCharacter {
        public string Name { get; }
        public int Level { get; }
        public int MaxHp => Level * 100;
        public int CurrentHp { get; private set; }
        public int AttackPower => Level * 10;
        public bool IsAlive => CurrentHp > 0;

        public GameCharacter(string name, int level) {
            Name = name;
            Level = level;
            CurrentHp = MaxHp;
        }

        public void Attack(GameCharacter target) {
            target.TakeDamage(this.AttackPower);
            Console.WriteLine($"{Name}이(가) {target.Name}에게 {this.AttackPower} 데미지를 입혔습니다!");
        }

        public void TakeDamage(int damage) {
            if (CurrentHp < damage) {
                CurrentHp = 0;
            } else {
                CurrentHp -= damage;
            }
        }

        public void ShowStatus() {
            Console.WriteLine($"[{Name}] Lv.{Level} - HP: {CurrentHp, 3}/{MaxHp, 3}, 공격력 : {AttackPower}");
        }

    }
}
