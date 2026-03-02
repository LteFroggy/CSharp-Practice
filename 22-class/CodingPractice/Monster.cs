using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice {
    internal class Monster {
        public string Name {get; set;}
        public int Health {get; set;}
        public void Attack() {
            Console.WriteLine($"{Name}이(가) 공격합니다!");
        }
    }
}
