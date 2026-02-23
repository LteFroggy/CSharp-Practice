using System;

int idx = 0;
int sum = 0;
int skipCount = 0;

while (true) {
    if (idx++ % 4 == 0) { 
        skipCount++;
        continue;
    }

    sum += idx;

    if (sum >= 200) { break; }
}

Console.WriteLine($"=== 결과 ===");
Console.WriteLine($"마지막 숫자 : {idx}");
Console.WriteLine($"건너뛴 횟수 : {skipCount}");
Console.WriteLine($"최종 합계 : {sum}");
Console.WriteLine();
Console.WriteLine();
