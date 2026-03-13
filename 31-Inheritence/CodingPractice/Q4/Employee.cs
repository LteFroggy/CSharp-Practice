using System;

namespace CodingPractice.Q4 {
    internal class Employee {
        protected string _department;

        protected void ShowDepartment() {
            Console.WriteLine($"소속 부서 : {_department}");
        }
    }
}
