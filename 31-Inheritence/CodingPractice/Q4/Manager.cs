using System;

namespace CodingPractice.Q4 {
    internal class Manager : Employee {
        public void ShowInfo() {
            ShowDepartment();
            Console.WriteLine($"부서 : {_department}");
        }
    }
}
