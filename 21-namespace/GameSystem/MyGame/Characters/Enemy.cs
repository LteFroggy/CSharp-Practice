using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Characters {
    internal class Enemy {
        private string _type;

        public Enemy(string type) {
            _type = type;
        }

        public void TakeDamage() {
            Console.WriteLine($"적 {_type}(이)가 데미지를 받았습니다!");
        }
    }
}
