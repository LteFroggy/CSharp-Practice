using System;

namespace EmployeeSystem {
    internal class Manager: Employee {
        private int _bonus;

        public Manager(int bonus, string name, int baseSalary) : base(name, baseSalary) {
            _bonus = bonus;
        }

        public override int CalculatePay() {
            return _bonus + GetBaseSalary();
        }

        public override void PrintInfo() {
            Console.WriteLine($"[매니저] {GetName()}");
            Console.WriteLine($"기본급 : {GetBaseSalary():N0}원");
            Console.WriteLine($"보너스 : {_bonus}");
            Console.WriteLine($"총 급여 : {CalculatePay():N0}원");
        }
    }
}
