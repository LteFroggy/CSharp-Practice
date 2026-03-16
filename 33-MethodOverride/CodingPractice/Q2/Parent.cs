using System;
using System.Security;

namespace Q2 {
    internal class Parent {
        public void Say() {
            Console.WriteLine($"부모_안녕하세요");
        }
        public void Run() {
            Console.WriteLine($"부모_달리다");
        }
        public virtual void Walk() {
            Console.WriteLine($"부모_걷다");
        }
    }
}
