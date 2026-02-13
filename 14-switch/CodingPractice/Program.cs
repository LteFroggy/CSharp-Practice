using System;
using System.Diagnostics.Contracts;
using System.Threading;

// 1. Switch문의 기본 구조
{
    int x = 2;
    switch (x) {
        case 1:
            Console.WriteLine("1입니다");
            break;
        case 2:
            Console.WriteLine("2입니다");
            break;
    }
    Console.WriteLine();
}

// 2. 정수형 switch문
{
    Console.WriteLine("정수를 입력하세요.");
    int inputVal = Convert.ToInt32(Console.ReadLine());
    switch (inputVal) {
        case 1:
            Console.WriteLine("1을 선택했습니다.");
            break;
        case 2:
            Console.WriteLine("2를 선택했습니다.");
            break;
        case 3:
            Console.WriteLine("3을 선택했습니다.");
            break;
        default :
            Console.WriteLine("그냥 찍으셨군요.");
            break;
    }
    Console.WriteLine();
}

// 2-2. 문자열 switch문
{
    Console.WriteLine("오늘 날씨는 어떤가요? (맑음, 흐림, 비, 눈, ...)");
    string inputVal = Console.ReadLine();
    switch (inputVal) {
        case "맑음":
            Console.WriteLine("오늘 날씨는 맑군요.");
            break;
        case "흐림":
            Console.WriteLine("오늘 날씨는 흐리군요.");
            break;
        case "비":
            Console.WriteLine("오늘 날씨는 비가 오는군요.");
            break;
        default:
            Console.WriteLine("혹시 눈이 내리나요?");
            break;
    }
    Console.WriteLine();
}

// 2-3. 문자형 switchg문
{
    char signalLight = 'G';
    string message = "";
    switch (signalLight) {
        case 'G':
            message = "녹색 : 이동하세요.";
            break;
        case 'R':
            message = "적색 : 멈추세요";
            break;
        case 'Y':
            message = "황색 : 주의하세요";
            break;
        default :
            message = "신호등 고장.";
            break;
    }
    Console.WriteLine(message);
    Console.WriteLine();
}

// 3-1. 여러 case 묶기
{
    int cardNumber = 12;
    switch (cardNumber) {
        case 11:
        case 12:
        case 13:
            Console.WriteLine("그림 카드입니다.");
            break;
        default :
            Console.WriteLine("숫자 카드입니다.");
            break;
    }
    Console.WriteLine();
}

// 3-2. 메뉴 선택
{
    Console.WriteLine("가장 좋아하는 프로그래밍 언어는? \n" +
                      "1. C \t 2. C++ \t 3. C# \t 4. Java");
    int inputVal = Convert.ToInt32(Console.ReadLine());
    switch (inputVal) {
        case 1 :
            Console.WriteLine("C 선택");
            break;
        case 2 :
            Console.WriteLine("C++ 선택");
            break;
        case 3 :
            Console.WriteLine("C# 선택");
            break;
        case 4 :
            Console.WriteLine("Java 선택");
            break;
    }
    Console.WriteLine();
}

// 3-3. 간단한 계산기
{
    int first = 10;
    char op = '+';
    int second = 5;

    switch (op) {
        case '+':
            Console.WriteLine($"{first} {op} {second} = {first + second}");
            break;
        case '-':
            Console.WriteLine($"{first} {op} {second} = {first - second}");
            break;
        case '*':
            Console.WriteLine($"{first} {op} {second} = {first * second}");
            break;

    }
    Console.WriteLine();
}

// 4. if - else와 switch문 비교
{
    string color = "green";
    string result = default;

    switch (color) {
        case "green":
            result = "초록";
            break;
        case "red" :
            result = "빨강";
            break;
        case "blue" :
            result = "파랑";
            break;
        default :
            result = "기타 색상";
            break;
    }
    Console.WriteLine($"{color} : {result}");
}