using System;
using System.Collections.Specialized;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;

// 1. 첫 번째 for문 예제
{
    for (int i = 0; i < 3; i++) {
        Console.WriteLine("안녕하세요");
    }
    Console.WriteLine();
}

// 2. 반복 변수의 활용
{
    for (int i = 0; i < 5; i++) {
        Console.WriteLine($"Count : {i}");
    }
    Console.WriteLine();
}

// 3-1. 2씩 증가
{
    for (int i = 0; i < 5; i += 2) {
        Console.WriteLine(i);
    }
    Console.WriteLine();
}

// 3-2. 감소하는 반복
{
    for (int i = 5; i > 0; i--) {
        Console.WriteLine(i);
    }
    Console.WriteLine();
}

// 3-3. 증가와 감소 비교
{
    Console.WriteLine("증가 : ");
    for (int i = 1 ; i <= 5; i++) {
        Console.Write($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 5; i > 0; i--) {
        Console.Write($"{i}\t");
    }
    Console.WriteLine();
}

// 4. 합계 계산
{
    int n = 0, sum = 0;
    for (int i = 1; i <= n; i++) {
        sum += i;
    }
    Console.WriteLine($"1부터 {n}까지의 합 : {sum}");
    Console.WriteLine();
}

// 5. 조건을 활용한 반복
{
    int n = 10, sum = 0;
    for (int i = 0; i < n; i++) {
        if (i % 2 == 0) { sum += n; }
    }
    Console.WriteLine($"1부터 {n}까지 짝수의 합 : {sum}");
    Console.WriteLine();
}

// 6-1. 별 삼각형 출력
{
    for (int i = 0; i < 5; i++) {
        for (int j = 0; j <= i; j++) {
            Console.Write('*');
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


// 6-2. 구구단 출력
{
    for (int i = 1; i < 10; i++) {
        for (int j = 2; j < 10; j++) {
            Console.Write($"{j} * {i} = {j * i, 2}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// 7. 팩토리얼 계산
{
    for (int i = 1; i <= 5; i++) {
        int factorial = 1;
        for (int j = 1; j <= i; j++) {
            factorial *= j;
        }
        Console.WriteLine($"{i}! = {factorial}");
    }
    Console.WriteLine();
}

// 8. 무한 루프
{
    int count = 0;
    for (; ; ) {
        Console.WriteLine($"반복 {count}");
        if (++count >= 3) { break; }
    }
    Console.WriteLine("반복 종료");
    Console.WriteLine();
}

// 9. for 문의 구성 요소 생략
{
    int i = 0;
    for ( ; i < 3;) {
        Console.WriteLine(i++);
    }
    Console.WriteLine();
}
