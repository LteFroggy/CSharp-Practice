using System;
using System.Collections.Generic;
using System.Text;

namespace A12 {
    class Player {
        private int _health;
        public int Health { 
            get => _health;
            set => _health = Math.Clamp(value, 0, 100);
        }
    }
}
