using System;

namespace Q4_2 {
    internal class Example : IExample {
        void IExample.DoWork() {
            Console.WriteLine($"작업 수행");
        }
    }
}
