using System;

{
    // 1-1. 관계형 연산자 기본 사용법
    int x = 3, y = 5;
    Console.WriteLine(x == y);
    Console.WriteLine(x != y);
    Console.WriteLine(x > y);
    Console.WriteLine(x >= y);
    Console.WriteLine(x < y);
    Console.WriteLine(x <= y);
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 1-2. 같음 연산자 주의사항
    int score = 100;
    bool isMax = score == 100;
    Console.WriteLine(isMax);
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 1-3. 문자열 비교
    Console.WriteLine("Hello" == "Hello");
    Console.WriteLine("Hello" == "hello");
    Console.WriteLine("AAA" == "aaa");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 2-1. 논리 AND 연산자 (&&)
    Console.WriteLine($"true && true -> {true && true}");
    Console.WriteLine($"true && false -> {true && false}");
    Console.WriteLine($"false && true -> {false && true}");
    Console.WriteLine($"false && false -> {false && false}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 2-2. 논리 OR 연산자 (||)
    Console.WriteLine($"true || true -> {true || true}");
    Console.WriteLine($"true || false -> {true || false}");
    Console.WriteLine($"false || true -> {false || true}");
    Console.WriteLine($"false || false -> {false || false}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 2-3. 논리 NOT 연산자(!)
    Console.WriteLine($"!true -> {!true}");
    Console.WriteLine($"!false -> {!false}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 2-4. NOT 연산 예제
    bool isAlive = false;
    Console.WriteLine(!isAlive);
    Console.WriteLine(!!isAlive);
    Console.WriteLine(!(!(!isAlive)));
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 3-1. 관계형 연산자와 논리 연산자 조합
    int i = 3, j = 5;
    bool result = (i == 3) && (j != 3);
    Console.WriteLine(result);
    result = (i != 3) || (j == 3);
    Console.WriteLine(result);
    result = !(i >= 5);
    Console.WriteLine(result);
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 3-2. 복합 조건 예제
    Console.WriteLine(false && true);
    Console.WriteLine((1 == 1) || (1 != 1));
    Console.WriteLine(!(1 == 1));
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 3-3. 게임 예제 : 스킬 사용 조건
    int level = 10, mp = 50;
    bool isStunned = false;
    bool canUseSkill = (level >= 5) && (mp >= 30) && !isStunned;
    Console.WriteLine($"스킬 사용 가능 : {canUseSkill}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 4-1. 단락 평가의 활용
    string name = null;
    bool isValidName = (name != null) && (name.Length > 0);
    Console.WriteLine(isValidName);
    Console.WriteLine();
    Console.WriteLine();
}


{
    // 4-2. 비단락 연산자 (&와 |)
    bool a = true, b = false;
    Console.WriteLine(a && b);
    Console.WriteLine(a & b);
    Console.WriteLine(b && a);
    Console.WriteLine(b & a);
    Console.WriteLine(a || b);
    Console.WriteLine(a | b);
    Console.WriteLine(b || a);
    Console.WriteLine(b | a);
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 5. 연산자 우선순위
    int a = 5, b = 3, c = 7;
    bool result1 = a > b && b < c || a == 5;
    bool result2 = ((a > b) && (b < c)) || (a == 5);
    Console.WriteLine(result1);
    Console.WriteLine(result2);
    Console.WriteLine();
    Console.WriteLine();
}


Console.WriteLine();