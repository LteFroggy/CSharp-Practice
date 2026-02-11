using System;

{
    // 1-1. 기본 할당 연산자
    var name = "C#";
    var version = 10.0;
    Console.WriteLine($"{name} {version}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 1-2. 할당 연산자의 동작 원리
    int num = 10;
    int result = num + 5;
    Console.WriteLine(num);
    Console.WriteLine(result);
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 1-3. 변수 값 교환하기 (스왑)
    int i = 100;
    int j = 200;
    Console.WriteLine($"교환 전 : i = {i}, j = {j}");
    int tmp = i;
    i = j; j = tmp;
    Console.WriteLine($"교환 후 : i = {i}, j = {j}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 2-1. 기본형과 축약형 비교
    int x = 3, y = 3;
    x = x + 2; y += 2;
    Console.WriteLine($"x : {x}, y : {y}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 2-2. 복합 할당 연산자 활용
    int a = 10;
    Console.WriteLine($"초기값 : {a}");
    Console.WriteLine($"a += 5 결과 : {a += 5}");
    Console.WriteLine($"a -= 3 결과 : {a -= 3}");
    Console.WriteLine($"a *= 2 결과 : {a *= 2}");
    Console.WriteLine($"a /= 4 결과 : {a /= 4}");
    Console.WriteLine($"a %= 3 결과 : {a %= 3}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 2-3. 누적 연산 예제
    int total = 0;
    total += 10;
    total += 20;
    total += 30;
    Console.WriteLine($"총합 : {total}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 3-1. 증가 연산자
    int num = 10;
    num = num + 1;
    Console.WriteLine(num);
    num += 1;
    Console.WriteLine(num);
    num++;
    Console.WriteLine(num);
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 3-2. 감소 연산자
    int num = 10;
    num = num +- 1;
    Console.WriteLine(num);
    num -= 1;
    Console.WriteLine(num);
    num--;
    Console.WriteLine(num);
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 3-3. 전위 연산자 예제
    int i = 3;
    int j = ++i;
    Console.WriteLine($"i : {i}");
    Console.WriteLine($"j : {j}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 3-4. 후위 연산자 예제
    int x = 3;
    int y = x++;
    Console.WriteLine($"x : {x}");
    Console.WriteLine($"y : {y}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 3-5. 전위와 후위 비교 예제
    int a = 5, b = 5;
    Console.WriteLine(++a);
    Console.WriteLine(a);
    Console.WriteLine(b++);
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine(b);
}

{
    // 3-6. 증감 연산자 종합 예제
    int number1 = 3, number2 = 5, result1 = 0, result2 = 0;
    number1--;
    result1 = ++number1;
    ++number2;
    result2 = number2--;
    Console.WriteLine($"result1 : {result1}");
    Console.WriteLine($"result2 : {result2}");
    Console.WriteLine($"number1 : {number1}");
    Console.WriteLine($"number2 : {number2}");
    Console.WriteLine();
    Console.WriteLine();
}
Console.WriteLine();

