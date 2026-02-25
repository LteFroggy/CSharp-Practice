using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

Console.WriteLine();

// 1-1. 함수 없이 반복 코드
{
    Console.WriteLine("안녕하세요.");
    Console.WriteLine("안녕하세요.");
    Console.WriteLine("안녕하세요.");
    Console.WriteLine();
    Console.WriteLine();
}

// 1-2. 함수를 사용한 코드
{
    void SayHello() {
        Console.WriteLine("안녕하세요.");
    }

    SayHello();
    SayHello();
    SayHello();
    Console.WriteLine();
    Console.WriteLine();
}

// 2-1. 가장 간단한 함수
{
    void ShowMessage() { Console.WriteLine("Hello, World!"); }
    ShowMessage();
    Console.WriteLine();
    Console.WriteLine();
}

// 2-2. 함수 여러 번 호출
{
    void Hi() {
        Console.WriteLine("안녕하세요.");
    }
    Hi();
    Hi();
    Hi();
    Console.WriteLine();
    Console.WriteLine();
}

// 2-3. 함수 정의 위치
{
    Console.WriteLine("프로그램 시작");
    Greet();
    void Greet() {
        Console.WriteLine("반갑습니다!");
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 3-1. 매개변수란?
{
    void ShowMessage(string message) { Console.WriteLine(message); }
    ShowMessage("안녕하세요!");
    ShowMessage("반갑습니다!");
    ShowMessage("좋은 하루 되세요!");
    Console.WriteLine();
    Console.WriteLine();
}

// 3-2. 매개변수가 여러 개인 함수
{
    void PrintSum(int a, int b) { Console.WriteLine($"{a} + {b} = {a + b}"); }
    PrintSum(10, 20);
    PrintSum(5, 3);
    PrintSum(100, 200);
    Console.WriteLine();
    Console.WriteLine();
}

// 3-3. 다양한 타입의 매개변수
{
    void Introduce(string name, int age) {
        Console.WriteLine($"이름 : {name}, 나이 : {age}세");
    }
    Introduce("홍길동", 25);
    Introduce("김철수", 30);
    Console.WriteLine();
    Console.WriteLine();
}

// 4-1. 반환값이란?
{
    string GetGreeting() { return "안녕하세요!"; }
    string greet = GetGreeting();
    Console.WriteLine(greet);
    Console.WriteLine();
    Console.WriteLine();
}

// 4-2. 계산 결과 반환
{
    int Add(int a, int b) { return a + b; }
    Console.WriteLine($"결과 : {Add(10, 20)}");
    Console.WriteLine($"3 + 5 = {Add(3, 5)}");
    Console.WriteLine();
    Console.WriteLine();
}

// 4-3. 제곱 함수
{
    int Square(int x) { return x * x; }
    Console.WriteLine(Square(2));
    Console.WriteLine(Square(5));
    Console.WriteLine(Square(10));
    Console.WriteLine();
    Console.WriteLine();
}

// 4-4. 조건에 따른 반환 (if/else)
{
    int Max(int a, int b) { 
        if (a > b) { return a; }
        else { return b; }
    }

    Console.WriteLine($"5와 3중 큰 값 : {Max(5, 3)}");
    Console.WriteLine($"5와 3중 큰 값 : {Max(10, 20)}");
    Console.WriteLine();
    Console.WriteLine();
}

// 4-5. .조건에 따른 반환 (삼항 연산자)
{
    int Max(int a, int b) { return a > b ? a : b; }
    int Min(int a, int b) { return a < b ? a : b; }
    Console.WriteLine($"큰 값 : {Max(10, 5)}");
    Console.WriteLine($"작은 값 : {Min(10, 5)}");
    Console.WriteLine();
    Console.WriteLine();
}

// 5-1. 기본 매개변수란?
{
    void Log(string message, int level = 1) { 
        Console.WriteLine($"[Level {level}] {message}"); 
    }
    Log("디버그 메세지");
    Log("에러 메세지", 4);
    Console.WriteLine();
    Console.WriteLine();
}

// 5-2. 여러 개의 기본 매개변수
{
    void CreateCharacter(string name, int level = 1, string job = "전사") {
        Console.WriteLine($"캐릭터 생성 : {name} (Lv.{level}) - {job}");
    }

    CreateCharacter("용사");
    CreateCharacter("마법사", 5);
    CreateCharacter("암살자", 10, "도적");
    Console.WriteLine();
    Console.WriteLine();
}

// 6-1. 명명된 매개변수란?
{
    void PrintInfo(string name, int age, string city) {
        Console.WriteLine($"{name}, {age}세, {city}");
    }

    PrintInfo("홍길동", 25, "서울");
    PrintInfo("김철수", age : 30, city : "부산");
    PrintInfo(name : "이영희", age : 28, city : "대전");
    Console.WriteLine();
    Console.WriteLine();
}

// 6-2. 기본 매개변수와 함께 사용
{
    void Attack(string target, int damage = 10, bool isCritical = false) {
        Console.WriteLine($"{target}에게 {damage} 데미지 {(isCritical ? "(크리티컬!)" : "")}");
    }

    Attack("슬라임");
    Attack("고블린", isCritical : true);
    Attack("드래곤", damage : 100, isCritical : true);
    Console.WriteLine();
    Console.WriteLine();
}