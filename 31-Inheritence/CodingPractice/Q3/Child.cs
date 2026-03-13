using System;

namespace CodingPractice.Q3 {
    internal class Child : Parent {
        public void ShowValues() {
            Console.WriteLine(publicInt);
            Console.WriteLine(protectedInt);
        }
    }
}
