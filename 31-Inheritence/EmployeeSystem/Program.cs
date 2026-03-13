using System;
using EmployeeSystem;

Console.WriteLine($"=== 직원 급여 시스템 ===");
Employee employee;

employee = new Manager(1000000, "김부장", 5000000);
employee.PrintInfo();
Console.WriteLine();

employee = new Developer("이개발", 4000000, 10);
employee.PrintInfo();
Console.WriteLine();

employee = new Intern("박인턴");
employee.PrintInfo();
Console.WriteLine();