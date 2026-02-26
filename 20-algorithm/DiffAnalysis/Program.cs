using System;

int[] data = { 5, 8, 3, 11, 7, 15, 10 };
int maxIncreased = Int32.MinValue;
int maxDecresed = Int32.MaxValue;
int increseCount = 0, decresedCount = 0;

Console.WriteLine($"=== 인접 차이 분석 ===");
Console.WriteLine();
Console.Write($"데이터 : "); foreach (int i in data) { Console.Write($"{i} "); }
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"[인접 변화량]");
for (int i = 1; i < data.Length; i++) {
    // 증가
    if (data[i - 1] < data[i]) {
        increseCount++;
        if (maxIncreased < data[i] - data[i - 1]) { maxIncreased = data[i] - data[i - 1]; }
    }
    // 감소
    else if (data[i - 1] > data[i]) {
        decresedCount++;
        if (maxDecresed > data[i] - data[i - 1]) { maxDecresed = data[i] - data[i - 1]; }
    }

    Console.WriteLine($"{data[i - 1], 2} -> {data[i], 2} : {(data[i] - data[i - 1] > 0 ? "+" : "")}{data[i] - data[i - 1]}"); 
}
Console.WriteLine();

Console.WriteLine($"[분석 결과]");
Console.WriteLine($"최대 증가 : {maxIncreased, 2}");
Console.WriteLine($"최대 감소 : {maxDecresed, 2}");
Console.WriteLine($"증가 횟수 : {increseCount, 2}번");
Console.WriteLine($"감소 횟수 : {decresedCount, 2}번");
