using System;

int a, b;
while (true) {
    Console.Write("두 개 정수를 띄어쓰기로 구분하여 입력해주세요 : ");
    string input = Console.ReadLine();
    string[] splited = input.Split(' ');

    try {
        a = Convert.ToInt32(splited[0]);
        b = Convert.ToInt32(splited[1]);
    } catch {
        Console.WriteLine("입력이 올바르지 않습니다");
        continue;
    }

    break;
}

Console.WriteLine($"=== 비교 결과 ===");
Console.WriteLine($"{a} == {b} : {a == b}");
Console.WriteLine($"{a} != {b} : {a != b}");
Console.WriteLine($"{a} > {b} : {a > b}");
Console.WriteLine($"{a} >= {b} : {a >= b}");
Console.WriteLine($"{a} < {b} : {a < b}");
Console.WriteLine($"{a} <= {b} : {a <= b}");
Console.WriteLine($"둘 다 양수인가? {a >= 0 && b >= 0}");
Console.WriteLine();