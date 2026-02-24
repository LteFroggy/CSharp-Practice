using System;

int[,] int2DimArr = new int[3, 3] {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

Console.WriteLine("=== 행렬 대각선 합계 ===");
Console.WriteLine();

Console.WriteLine("[행렬 출력]");
for (int i = 0; i < int2DimArr.GetLength(0); i++) {
    for (int j = 0; j < int2DimArr.GetLength(1); j++) {
        Console.Write($"{int2DimArr[i, j]}   ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("[대각선 분석]");
int sum1 = 0, sum2 = 0, sum3 = 0;
for (int i = 0; i < int2DimArr.GetLength(0); i++) {
    sum1 += int2DimArr[i, i];
    sum2 += int2DimArr[i, int2DimArr.GetLength(0) - i - 1];
    if (i == int2DimArr.GetLength(0) - i - 1) { sum3 += int2DimArr[i, i]; }
}
Console.WriteLine($"주대각선 합계 : {sum1}");
Console.WriteLine($"부대각선 합계 : {sum2}");
Console.WriteLine($"대각선 교차점 : {sum3}");
