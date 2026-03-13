using System;

namespace CodingPractice.Q5_1 {
    internal class Person {
        public string Name { get; private set; }
        public Person(string name) {
            Console.WriteLine($"Person 생성자 호출 : {name}");
            Name = name;
        }
    }
}
