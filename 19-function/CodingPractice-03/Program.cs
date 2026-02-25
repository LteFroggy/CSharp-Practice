using System;
using System.Net.Http;
using System.Threading.Channels;

// 1-1. 재귀 함수란?
{
    void CountDown(int n) {
        if (n > 0) {
            Console.WriteLine(n);
            CountDown(n - 1);
        } else {
            Console.WriteLine("발사!");
        }
    }
    
    CountDown(5);
    Console.WriteLine();
    Console.WriteLine();
}

// 1-2. 팩토리얼 계산
{
    int Factorial(int n) {
        if (n == 1) { return 1; }
        else { return n * Factorial(n - 1); }
    }

    Console.WriteLine($"{5}! = {Factorial(5)}");
    Console.WriteLine($"{4}! = {Factorial(4)}");
    Console.WriteLine($"{3}! = {Factorial(3)}");
    Console.WriteLine();
    Console.WriteLine();
}

// 1-3. 반복문 vs 재귀 함수
{
    int FactorialLoop(int n) {
        int result = 1;
        for (int i = 1; i <= n; i++) { result *= i; }
        return result;
    }

    int FactorialRecursive(int n) {
        if (n == 1) { return 1; }
        else { return n * FactorialRecursive(n - 1); }
    }

    Console.WriteLine($"반복문 : {FactorialLoop(5)}");
    Console.WriteLine($"반복문 : {FactorialRecursive(5)}");
}

// 2-1. 지역 변수
{
    void ShowMesage() {
        string message = "함수 안의 지역 변수";
        Console.WriteLine(message);
    }

    // 접근 불가능
    // message = "Hello";
    Console.WriteLine();
    Console.WriteLine();
}

// 2-2. 블록 범위
{
    void TestScope() {
        int x = 10;
        if (x == 10) {
            int y = 20;
        } 
        // 접근 불가능
        // y = 30;
    }
}

// 2-3. 매개변수의 범위
{
    int value = 10;
    void ProcessValue(int value) {
        value *= 2;
        Console.WriteLine($"함수 안 : {value}");
    }
    Console.WriteLine($"호출 전 : {value}");
    ProcessValue(value);
    Console.WriteLine($"호출 후 : {value}");
    Console.WriteLine();
    Console.WriteLine();
}

// 3-1. 식 본문 메서드란?
{
    int Add(int a, int b) {
        return a + b;
    }

    int AddShort(int a, int b) => a + b;

    Console.WriteLine(Add(15, 15));
    Console.WriteLine(AddShort(15, 15));
    Console.WriteLine();
    Console.WriteLine();
}

// 3-2. 반환값이 없는 식 본문 메서드
{
    void SayHello() {
        Console.WriteLine("안녕하세요!");
    }

    void SayHelloTo(string name) => Console.WriteLine($"{name}님, 안녕하세요!");

    SayHello();
    SayHelloTo("홍길동");
    Console.WriteLine();
    Console.WriteLine();
}

// 3-3. 다양한 식 본문 메서드
{
    int Square(int x) => x * x;
    bool isPositive(int x) => x > 0;
    string GetGreeting(string name) => $"안녕하세요, {name}님!";

    Console.WriteLine(Square(5));
    Console.WriteLine(isPositive(-2));
    Console.WriteLine(GetGreeting("철수"));
    Console.WriteLine();
    Console.WriteLine();
}

// 4-1. 로컬 함수란?
{
    void OuterFunction() {
        Console.WriteLine("외부 함수 시작");
        InnerFunction();
        void InnerFunction() {
            Console.WriteLine("로컬 함수 실행");
        };
        Console.WriteLine("외부 함수 끝");
    }
    OuterFunction();
    Console.WriteLine();
    Console.WriteLine();
}

// 4-2. 로컬 함수 활용
{
    void CalculateArea() {
        void CircleArea(int radius) {
            Console.WriteLine($"반지름 {radius}인 원의 넓이 : {radius * 3.14:F2}");
        }

        void RectangleArea(int width, int height) {
            Console.WriteLine($"가로 {width}, 세로 {height}인 사각형의 넓이 : {width * height}");
        }

        CircleArea(5);
        RectangleArea(3, 4);
    }
    CalculateArea();
    Console.WriteLine();
    Console.WriteLine();
}

// 4-3. 최상위문에서 로컬 함수
{
    int Add(int a, int b) => a + b;
    int Subtract(int a, int b) => a - b;
    Console.WriteLine($"10 + 5 = {Add(10, 5)}");
    Console.WriteLine($"10 - 5 = {Subtract(10, 5)}");
    Console.WriteLine();
    Console.WriteLine();
}

// 5-1. 간단한 계산기
{
    void Calculate(int x, int y) {
        int Add(int a, int b) => a + b;
        int Subtract(int a, int b) => a - b;
        int Multiply(int a, int b) => a * b;
        int Divide(int a, int b) => a / b;

        Console.WriteLine("=== 간단한 계산기 ===");
        Console.WriteLine($"{x} + {y} = {Add(20, 5)}");
        Console.WriteLine($"{x} + {y} = {Subtract(20, 5)}");
        Console.WriteLine($"{x} + {y} = {Multiply(20, 5)}");
        Console.WriteLine($"{x} + {y} = {Divide(20, 5)}");
    }
    Calculate(20, 5);
    Console.WriteLine();
    Console.WriteLine();
}

// 5-2. 성적 처리 프로그램
{
    void PrintResult(string name, int kor, int eng, int math) {
        double GetAverage(int a, int b, int c) {
            return (double)(a + b + c) / 3;
        }

        char GetGrade(int a, int b, int c) {
            double avg = GetAverage(a, b, c);
            if (avg >= 90) return 'A';
            else if (avg >= 80) return 'B';
            else if (avg >= 70) return 'C';
            else if (avg >= 60) return 'D';
            else return 'F';
        }

        Console.WriteLine($"이름 : 홍길동");
        Console.WriteLine($"점수 : 국어 {kor}, 영어 {eng}, 수학 {math}");
        Console.WriteLine($"평균 : {GetAverage(kor, eng, math):F1}, 학점 : {GetGrade(kor, eng, math)}");
    }
    Console.WriteLine("=== 성적 처리 결과 ===");
    PrintResult("홍길동", 95, 88, 92);
    Console.WriteLine();
    PrintResult("김철수", 78, 85, 72);
    Console.WriteLine();
    PrintResult("이영희", 65, 70, 68);
    Console.WriteLine();
    Console.WriteLine();
}

// 5-3. 피보나치 수열
{
    int Fibonacci(int n) {
        return n <= 1 ? 1 : Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    int count = 10;
    Console.WriteLine($"=== 피보나치 수열 ===");
    Console.Write($"처음 {count}개 : ");
    for (int i = 0; i < count; i++) {
        Console.Write($"{Fibonacci(i)}  ");
    }
    Console.WriteLine();
    Console.WriteLine();
}