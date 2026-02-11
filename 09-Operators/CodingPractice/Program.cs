using System;
using System.Reflection.Metadata;

{
    // 1. 연산자와 피연산자
    Console.WriteLine(3 + 5);
    Console.WriteLine(3 - 5);
    Console.WriteLine(3 * 5);
    Console.WriteLine(3 / 5);
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 2-1. 양수 연산자 (+)
    int value = 8;
    value = +value;
    Console.WriteLine(value);
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 2-2. 음수 연산자 (-)
    int value = 8;
    value = -value;
    Console.WriteLine(value);

    value = -8;
    value = -value;
    Console.WriteLine(value);

    Console.WriteLine();
    Console.WriteLine();
}

{
    // 3. 변환 연산자(캐스팅)
    int val = (int)3.14;
    Console.WriteLine(val);
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 4. 덧셈 연산자 (+)
    int i = 10;
    int j = 20;
    int k = i + j;
    Console.WriteLine(k);
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 5. 뺼셈 연산자 (-)
    decimal i = 3.14M;
    decimal j = 3.14M;
    Console.WriteLine(i - j);
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 6. 곱셈 연산자 (*)
    long i = 100;
    long j = 200;
    long k = i * j;
    Console.WriteLine(k);
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 7-1. 실수 나눗셈
    double i = 1.5;
    double j = 0.5;

    double k = i / j;
    Console.WriteLine(k);
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 7-2. 정수 나눗셈과 실수 나눗셈 비교
    int a = 5, b = 3;
    Console.WriteLine(a / b);
    Console.WriteLine((double)a / b);
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 8-1. 나머지 구하기
    int first = 5, second = 3;
    int result = first % second;
    Console.WriteLine(result);
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 8-2. 짝수 판별
    int number = 10;

    if (number % 2 == 0) Console.WriteLine("짝수입니다");
    else Console.WriteLine("홀수입니다");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 9. 산술 연산자 종합
    int a = 5, b = 3;
    Console.WriteLine(a + b);
    Console.WriteLine(a - b);
    Console.WriteLine(a * b);
    Console.WriteLine(a / b);
    Console.WriteLine($"{a} % {b} = {a % b}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 10-1. 문자열 연결
    Console.WriteLine("Hello" + "World");
    Console.WriteLine("Hi" + " " + "everyone");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 10-2. 문자열과 다른 타입의 연결
    Console.WriteLine("123" + "456");
    Console.WriteLine("123" + 456);
    Console.WriteLine(123 + "456");
    Console.WriteLine(123 + 456);
    Console.WriteLine("123" + true);
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 11. 연산자 우선순위
    int result = 1 + 2 * 3;
    Console.WriteLine(result);
    result = (1 + 2) * 3;
    Console.WriteLine(result);
    Console.WriteLine();
    Console.WriteLine();
}

Console.WriteLine();