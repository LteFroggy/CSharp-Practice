using System;
using System.ComponentModel;

class Program {
    void Greet() {
        Console.WriteLine("안녕하세요");
    }

    void Greet(string name) {
        Console.WriteLine($"{name}님, 안녕하세요.");
    }

    void Greet(string name, int times) {
        for (int i = 0; i < times; i++) { Console.WriteLine($"{name}님, 안녕하세요."); }
    }

    public static void Main() {
        // 1. 매개변수 개수에 따른 오버로드
        Program myP = new Program();
        myP.Greet();
        myP.Greet("홍길동");
        myP.Greet("김철수", 3);

        Console.WriteLine();
        Console.WriteLine();

        // 2. 매개변수 타입에 따른 오버로드
        Console.WriteLine(Calculator.Add(10, 20));
        Console.WriteLine($"{Calculator.Add(3.1, 2.7):F1}");
        Console.WriteLine(Calculator.Add("Hello, ", "World!"));
    }
}

class Calculator {
    public static int Add(int a, int b) {
        return a + b;
    }
    public static double Add(double a, double b) {
        return a + b;
    }
    public static string Add(string a, string b) {
        return a + b;
    }
}