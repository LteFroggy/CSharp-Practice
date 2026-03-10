using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace A18 {
    class Monster {
        private int _health;
        private string _name;

        public Monster(string name) {
            Health = 100;
            _name = name;
        }

        public int Health {
            get => _health;
            set => _health = Math.Clamp(value, 0, 100);
        }

        public int Level { get; set; }
        public int Attack { get; set; }
        public string Name { get => _name; }
        public bool IsAlive { get =>  _health > 0; }
        public int Defense { get => Level * 2; }
        
        public void TakeDamage(int amount) {
            Health -= amount;
        }
    }
}
