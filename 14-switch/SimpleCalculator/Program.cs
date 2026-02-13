using System;

int a = default, b = default;
char op = default;

while (true) {
    Console.Write("첫 번째 숫자 : ");
    try {
        a = Convert.ToInt32(Console.ReadLine());
    } catch {
        Console.WriteLine("정수로 입력해주세요.");
        continue;
    }
    break;
}

while (true) {
    Console.Write("연산자 (+, -, *, /, %) : ");
    try {
       op = Convert.ToChar(Console.ReadLine());
    } catch {
        Console.WriteLine("올바른 연산자를 입력해주세요.");
        continue;
    }
    break;
}

while (true) {
    Console.Write("두 번째 숫자 : ");
    try {
        b = Convert.ToInt32(Console.ReadLine());
    } catch {
        Console.WriteLine("정수로 입력해주세요.");
        continue;
    }
    break;
}

switch (op) {
    case '+' :
        Console.WriteLine($"결과 : {a} {op} {b} = {a + b}");
        break;
    case '-':
        Console.WriteLine($"결과 : {a} {op} {b} = {a - b}");
        break;
    case '*':
        Console.WriteLine($"결과 : {a} {op} {b} = {a * b}");
        break;
    case '/':
        Console.WriteLine($"결과 : {a} {op} {b} = {a / b}");
        break;
    case '%':
        Console.WriteLine($"결과 : {a} {op} {b} = {a % b}");
        break;
    default :
        Console.WriteLine("지원하지 않는 연산자입니다.");
        break;
}       

