using System;

int score;
while (true) {
    Console.Write("점수를 입력해주세요(0-100) : ");
    string input = Console.ReadLine();
    try {
        score = Convert.ToInt32(input);
        if (score > 100 || score < 0) throw new Exception();
    } catch {
        Console.WriteLine("올바른 정수 값을 입력해주세요");
        continue;
    }
    break;
}

Console.WriteLine($"=== 등급 판정 결과 ===");
Console.WriteLine($"A등급 (90 ~ 100)인가? : {score >= 90}");
Console.WriteLine($"B등급 (80 ~ 89)인가? : {score >= 80}");
Console.WriteLine($"C등급 (70 ~ 79)인가? : {score >= 70}");
Console.WriteLine($"D등급 (60 ~ 69)인가? : {score >= 60}");
Console.WriteLine($"F등급 (0 ~ 59)인가? : {score >= 0}");
Console.WriteLine();
Console.WriteLine();