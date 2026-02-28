using System;
using System.Collections.Generic;
using System.Text;

namespace Casual {
    internal class Message {
        public static void SayHello(string name) {
            Console.WriteLine($"안녕, {name}!");
        }

        public static void SayBye(string name) {
            Console.WriteLine($"잘 가, {name}!");
        }
    }
}
