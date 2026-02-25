using System;
using System.Data;

class Calculator {
    public static double CalculateBmi(double height, double weight) {
        return weight / (height * height / 10000);
    }

    public static string GetCategory(double bmi) {
        if (bmi < 18.5) { return "저체중"; }
        if (bmi < 23.0) { return "정상"; }
        if (bmi < 25.0) { return "과체중"; }
        return "비만";
    }

    public static void PrintResult(string name, double height, double weight) {
        Console.WriteLine($"[{name}]");
        Console.WriteLine($"키 : {height}cm, 몸무게 : {weight}kg");
        Console.WriteLine($"BMI : {CalculateBmi(height, weight):F1}, 판정 : {GetCategory(CalculateBmi(height, weight))}");
    }
}

class Program {
    public static void Main() {
        Console.WriteLine($"=== BMI 계산기 ===");
        Calculator.PrintResult("홍길동", 175, 70);
        Console.WriteLine();
        Calculator.PrintResult("김철수", 168, 85);
        Console.WriteLine();
        Calculator.PrintResult("이영희", 160, 45);
        Console.WriteLine();
        Console.WriteLine();
    }
}