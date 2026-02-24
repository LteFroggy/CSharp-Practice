using System;

int[] intArr = { 1, 2, 3, 4, 5 };
int rotateCount = 2;

Console.Write($"원본 배열 : ");
foreach (int i in intArr) { Console.Write($"{i} "); }
Console.WriteLine();
Console.WriteLine($"회전 횟수 : {rotateCount}칸 (오른쪽)");
Console.WriteLine();
Console.WriteLine();

// 반시계 회전 수행
for (int k = 0; k < rotateCount; k++) {
    int tmp = intArr[intArr.Length - 1];
    for (int i = intArr.Length - 1; i > 0; i--) {
        intArr[i] = intArr[i - 1];
    }
    intArr[0] = tmp;
}

Console.Write($"회전 결과 : ");
foreach (int i in intArr) { Console.Write($"{i} "); }
Console.WriteLine();
Console.WriteLine();