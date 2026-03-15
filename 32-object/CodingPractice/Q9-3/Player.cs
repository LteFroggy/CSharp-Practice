using System;

namespace CodingPractice.Q9_3 {
    internal class Player {
        public Player(string name, int level, int health) {
            Name = name;
            Level = level;
            Health = health;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }

        public override string ToString() {
            return $"Player Name = {{ {Name}, Level = {Level}, Health = {Health} }}";
        }
    }
}
