using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Characters {
    internal class Player {
        private string _name;
        public Player(string name) {
            _name = name;
        }

        public void Attack() {
            Console.WriteLine($"플레이어 {_name}(이)가 공격합니다!");
        }
    }
}
