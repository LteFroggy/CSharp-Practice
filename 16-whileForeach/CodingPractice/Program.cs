using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;


// 1-1. While문의 기본 구조
{
    int count = 0;
    while (count++ < 3) {
        Console.WriteLine("안녕하세요");
    }
    Console.WriteLine();
}

// 1-2. 카운트다운 출력하기
{
    int index = 5;
    while (index-- > 0) {
        Console.WriteLine($"카운트 : {index}");
    }
    Console.WriteLine("발사!");
    Console.WriteLine();
} 

// 1-3. 1부터 100까지의 합 구하기
{
    const int k_Max = 100;
    int sum = 0;
    int idx = 0;
    while (idx <= k_Max) {
        sum += idx++;
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 1-4. 짝수의 합 구하기
{
    int idx = 0;
    int sum = 0;
    while (idx <= 100) {
        if (idx++ % 2 == 0) {
            sum += idx;
        }
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 1-5. 7의 배수의 합 구하기
{
    int idx = 0;
    int sum = 0;
    while (idx <= 50) {
        if (idx++ % 7 == 0) {
            sum += idx;
        }
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 1-6. 피보나치 수열 출력하기
{
    int first = 1, second = 1;
    int result = first + second;
    Console.WriteLine("피보나치 수열 (20 이하)");
    Console.WriteLine($"{first}\n{second}");
    while (result < 20) {
        Console.WriteLine($"{result}");
        first = second;
        second = result;
        result = first + second;
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 2-1. do-while문의 기본 구조
{
    int count = 0;
    do {
        Console.WriteLine("안녕하세요.");
    } while (count++ < 3);
    Console.WriteLine();
    Console.WriteLine();
}

// 2-2. while문과 do-while문의 차이
{
    int x = 10;
    while (x < 5) { }
    Console.WriteLine("While문 종료");

    x = 10;
    do { } while (x < 5);
    Console.WriteLine();
    Console.WriteLine();
}

// 2-3. 1부터 5까지의 합 구하기 (do-while)
{
    int idx = 1;
    int sum = 0;
    do {
        sum += idx++;
    } while (idx <= 5);
    Console.WriteLine();
    Console.WriteLine();
}

// 2-4. 3과 4의 공배수 합 구하기
{
    int idx = 0;
    int sum = 0;
    do {
        if (((++idx % 3) & (idx % 4)) == 0) {
            sum += idx;
        }
    } while (idx < 100);
    Console.WriteLine();
    Console.WriteLine();
}

// 3-1. foreach문의 기본 구조
{
    string[] languages = {
        "C#",
        "Java",
        "Python"
    };

    foreach (string language in languages) {
        Console.WriteLine(language);
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 3-2. 문자열에서 문자 하나씩 출력하기
{
    string text = "Hello";
    foreach (char c in text) {
        Console.WriteLine($"{c} ");
    }
}

// 3-3. 문자열에서 문자 분석하기
{
    string code = "ABC123";
    foreach(char val in code) {
        if (val >= 'A' && val <='Z') {
            Console.WriteLine($"{val} = 문자");
        } else {
            Console.WriteLine($"{val} = 문자");
        }
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 3-4. 정수 배열의 값 구하기
{
    int[] numbers = {10, 20, 30, 40, 50};
    int sum = 0;
    foreach(int val in numbers) { 
        sum += val;
    }
    Console.WriteLine($"배열 요소의 합 : {sum}");
    Console.WriteLine();
    Console.WriteLine();
}

// 3-5. 배열에서 최댓값 찾기
{
    int[] scores = {95, 82, 78, 95, 88};
    int max = 0;
    foreach (int score in scores) {
        max = max < score ? score : max;
    }
}

// 3-6. var키워드와 foreach
{
    var items = new[] {"사과", "바나나", "체리"};
    foreach(var item in items) {
        Console.WriteLine(item);
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 4-1. for문 vs while문
{
    int i = 0;
    for (i = 1; i < 6; i++) {
        Console.Write($"{i} ");
    } Console.WriteLine();
    i = 1;
    while (i++ < 6) {
        Console.Write($"{i} ");
    } Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
}

// 4-2. for문 vs foreach문
{
    string[] items = {"사과", "바나나", "체리"};
    Console.WriteLine("for 문 : ");
    for (int i = 0; i < items.Length; i++) {
        Console.WriteLine($"{i} : {items[i]}");
    }

    Console.WriteLine("foreach 문 : ");
    foreach (string item in items) {
        Console.WriteLine(item);
    }
}