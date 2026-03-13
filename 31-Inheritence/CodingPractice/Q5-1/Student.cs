using System;

namespace CodingPractice.Q5_1 {
    internal class Student : Person {
        public int Grade { get; private set; }
        public Student(string name, int grade) : base(name) {
            Console.WriteLine($"Student 생성자 호출 : {grade}");
        }

        public void ShowInfo() {
            Console.WriteLine($"이름 : {Name}, 학년 : {Grade}");
        }
    }
}
