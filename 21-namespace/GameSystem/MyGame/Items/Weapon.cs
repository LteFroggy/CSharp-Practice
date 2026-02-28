using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Items {
    internal class Weapon {
        private string _name;
        private int _damage;

        public Weapon(string name, int damage) {
            _name = name;
            _damage = damage;
        }

        public void GetDamage() {
            Console.WriteLine($"무기 {_name}의 공격력 : {_damage}");
        }
    }
}
