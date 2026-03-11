using System;


// 1. 기본 인덱서 예제
{
    Catalog catalog = new Catalog();
    for (int i = 0; i < 3; i++) {
        Console.WriteLine(catalog[i]);
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 2. 배열 필드를 감싸는 인덱서
{
    Car c1 = new Car(3);
    c1[0] = "CLA";
    c1[1] = "CLS";
    c1[2] = "AMG";

    for (int i = 0; i < 3; i++) {
        Console.WriteLine(c1[i]);
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 3. 요일 클래스 예제
{
    Week week = new Week(3);
    week[0] = "일요일";
    week[1] = "월요일";
    week[2] = "화요일";

    for (int i = 0; i < 3; i++) {
        Console.WriteLine(week[i]);
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 4. 문자열 인덱서
{
    Nickname nickname = new Nickname();

    nickname["홍길동"] = "RedPlus";
    nickname["김철수"] = "Bluestar";

    Console.WriteLine($"{nickname["홍길동"]}, {nickname["김철수"]}");
}

// 5. 다중 인덱서
{
    MultiIndexer mul = new MultiIndexer();

    mul[0] = "첫 번째 값";
    mul["name"] = "홍길동";
    mul["city"] = "서울";

    Console.WriteLine($"mul[0] = {mul[0]}");
    Console.WriteLine($"mul[\"name\"] = {mul["name"]}");
    Console.WriteLine($"mul[\"city\"] = {mul["city"]}");
    Console.WriteLine();
    Console.WriteLine();
}

// 6. 인덱서와 속성의 비교
{
    Example example = new Example();
    example.Name = "홍길동";
    Console.WriteLine(example.Name);
    Console.WriteLine($"{example[0]}, {example[1]}");
}