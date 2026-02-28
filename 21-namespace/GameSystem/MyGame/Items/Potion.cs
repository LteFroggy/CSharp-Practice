using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Items {
    internal class Potion {
        private string _name;

        public Potion(string name) {
            _name = name;
        }

        public void Use() {
            Console.WriteLine($"포션 {_name}(을)를 사용했습니다.");
        }
    }
}
