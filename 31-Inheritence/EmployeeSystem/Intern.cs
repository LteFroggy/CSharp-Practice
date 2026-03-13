using System;

namespace EmployeeSystem {
    internal class Intern: Employee {

        public Intern(string name) : base(name, 1500000) { }

        public override void PrintInfo() {
            Console.WriteLine($"[인턴] {GetName()}");
            Console.WriteLine($"기본급 : {GetBaseSalary():N0}원");
            Console.WriteLine($"총 급여 : {CalculatePay():N0}원");
        }
    }
}
