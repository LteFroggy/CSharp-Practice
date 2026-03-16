using System;
using System.Security.Cryptography.X509Certificates;

namespace Q5 {
    internal class Child : Parent {
        public override sealed void Work() {
            Console.WriteLine($"프로그래머");
        }
    }
}
