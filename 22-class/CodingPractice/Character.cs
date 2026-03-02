using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice {
    internal class Character {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Job { get; set; }

        public void PrintInfo() {
            Console.WriteLine($"{Name} - Lv.{Level} {Job}");
        }
    }
}
