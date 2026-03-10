using System;
using System.Collections.Generic;
using System.Text;

namespace A2 {
    internal class Player {
        private int _health;

        public int GetHealth() => _health;
        public void SetHealth(int health) { 
            _health = Math.Clamp(health, 0, 100);
        }
    }
}
