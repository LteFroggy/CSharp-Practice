using System;
using System.Globalization;

// 1. 배열이 필요한 이유
{
    int kor1 = 90;
    int kor2 = 80;
    int kor3 = 70;

    Console.WriteLine($"총점 : {kor1 + kor2 + kor3}");
    Console.WriteLine();
    Console.WriteLine();
}

// 2-1. 배열 요소 접근
{
    int[] intArr = new int[3] { 10, 20, 30 };
    Console.WriteLine($"첫 번째 : {intArr[0]}");
    Console.WriteLine($"두 번째 : {intArr[1]}");
    Console.WriteLine($"세 번째 : {intArr[2]}");
    Console.WriteLine();
    Console.WriteLine();
}

// 2-2. 배열 초기화
{
    string[] phones = { "112", "119", "114" };
    Console.WriteLine($"경찰 : {phones[0]}");   
    Console.WriteLine($"소방 : {phones[1]}");   
    Console.WriteLine($"전화번호 안내 : {phones[2]}");   
}

// 2-3. Length 속성
{
    int[] numbers = { 10, 20, 30, 40, 50 };
    Console.WriteLine($"배열의 길이 : {numbers.Length}");
    Console.WriteLine();
    Console.WriteLine();
}

// 3-1. for문 사용
{
    int[] numbers = { 1, 2, 3, 4, 5 };
    for (int i = 0; i < numbers.Length; i++) {
        Console.WriteLine($"numbers[{i}] = {numbers[i]}");
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 3-2. foreach문 사용
{
    int[] scores = { 10, 20, 30 };
    int sum = 0;
    foreach (int score in scores) { sum += score; }
    Console.WriteLine($"합계 : {sum}");
    Console.WriteLine();
    Console.WriteLine();
}

// 3-3. 배열 합계와 평균 구하기
{
    int[] kor = { 100, 90, 80 };
    int sum = 0;
    for (int i = 0; i < kor.Length; i++) {
        sum += kor[i];
    }
    Console.WriteLine($"총점 : {sum}, 평균 : {(double)sum / kor.Length}");
    Console.WriteLine();
    Console.WriteLine();
}

// 4-1. 2차원 배열
{
    int[,] int2DimArr = new int[2, 3] {
        { 1, 2, 3 },
        { 4, 5, 6 }
    };

    for (int i = 0; i < int2DimArr.GetLength(0); i++) {
        for (int j = 0; j < int2DimArr.GetLength(1); j++) { Console.Write($"{int2DimArr[i, j]} "); }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 4-2. 2차원 배열 초기화
{
    int[,] int2DimArr = new int[2, 3] {
        { 1, 2, 3 },
        { 4, 5, 6 }
    };
    Console.WriteLine($"행 수 : {int2DimArr.GetLength(0)}");
    Console.WriteLine($"열 수 : {int2DimArr.GetLength(1)}");
    for (int i = 0; i < int2DimArr.Length; i++) {
        Console.Write($"matrix[{i / 3}, {i % 3}] = {int2DimArr[i / 3, i % 3]} ");
        if (i % 3 == 2) { Console.WriteLine(); }
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 4-3. 가변 배열
{
    int[][] myJaggedArr = new int[3][] {
        new int[] { 1, 2, 3, 4, 5 },
        new int[] { 6, 7, 8 },
        new int[] { 9, 10, 11, 12 }
    };

    foreach (int[] arr in myJaggedArr) {
        foreach (int i in arr) {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 5. var키워드로 배열 선언
{
    var intArr = new int[] { 1, 2, 3 };
    var stringArr = new string[] { "Alice", "Bob" };

    Console.WriteLine($"numbers 타입 : {intArr.GetType()}");
    Console.WriteLine($"names 타입 : {stringArr.GetType()}");
    Console.WriteLine($"numbers 타입 : {intArr[0].GetType()}");
    Console.WriteLine($"numbers 타입 : {intArr[1].GetType()}");
    Console.WriteLine($"numbers 타입 : {intArr[2].GetType()}");
    Console.WriteLine();
    Console.WriteLine();
}