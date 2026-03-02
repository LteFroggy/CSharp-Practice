using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice {
    internal class Player {
        public string name;
        public int health;

        public Player() {
            name = "Unknown";
            health = 100;
        }
        public Player(string name, int health) {
            this.name = name;
            this.health = health;
        }

        public void PrintInfo() {
            Console.WriteLine($"이름 : {name}, 체력 : {health}");
        }
    }
}
