using System;

namespace ZooSimulator {
    abstract internal class Animal {
        private string _name;
        private int _age;

        public string Name { get { return _name; } }
        public int Age { get { return _age; } }
        

        protected Animal(string name, int age) {
            _name = name;
            _age = age;
        }


        public void Eat() {
            Console.WriteLine($"{Name}이(가) 먹이를 먹습니다.");
        }
        abstract public void MakeSound();

        public void DisplayInfo() {
            Console.WriteLine($"이름 : {Name}, 나이 : {Age}살");
        }
    }
}
