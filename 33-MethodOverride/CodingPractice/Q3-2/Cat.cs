using System;
using System.Threading.Channels;

namespace Q3_2 {
    internal class Cat : Animal {
        public override void Speak() {
            Console.WriteLine($"야옹!");
        }
    }
}
