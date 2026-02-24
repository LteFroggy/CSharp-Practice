using System;

int[] intArr = { -5, 12, 0, -8, 7, 15, -3, 20, 9, -1 };

Console.WriteLine($"=== 숫자 분류기 ===");
Console.WriteLine($"[원본 배열]");
for (int i = 0; i < intArr.Length; i++) {
    Console.Write($"{(i == 0 ? "" : ", ")} {intArr[i]}");
} Console.WriteLine();
Console.WriteLine();

int[] posArr = new int[intArr.Length];
int[] negArr = new int[intArr.Length];
int[] zeroArr = new int[intArr.Length];
int[] oddArr = new int[intArr.Length];
int[] evenArr = new int[intArr.Length];
int[] absOver10Arr = new int[intArr.Length];
int posIdx = 0, negIdx = 0, zeroIdx = 0, oddIdx = 0, evenIdx = 0, absOver10Idx = 0;

foreach (int val in intArr) { 
    if (val < 0) posArr[posIdx++] = val;
    else if (val > 0) negArr[negIdx++] = val;
    else zeroArr[zeroIdx++] = val;

    if (val % 2 == 0) { evenArr[evenIdx++] = val; }
    else { oddArr[oddIdx++] = val; }

    if (val >= 10 || val <= -10) { absOver10Arr[absOver10Idx++] = val; }
}

Console.WriteLine("[양수/음수/영 분류]");

Console.Write($"양수 : ({posIdx}개) : ");
for (int i = 0; i < posIdx; i++) {
    Console.Write($"{(i == 0 ? "" : ", ")}{posArr[i]}");
} Console.WriteLine();

Console.Write($"음수 : ({negIdx}개) : ");
for (int i = 0; i < negIdx; i++) {
    Console.Write($"{(i == 0 ? "" : ", ")}{negArr[i]}");
} Console.WriteLine();

Console.Write($"영 : ({zeroIdx}개) : ");
for (int i = 0; i < zeroIdx; i++) {
    Console.Write($"{(i == 0 ? "" : ", ")}{zeroArr[i]}");
} Console.WriteLine();
Console.WriteLine();

Console.WriteLine("[홀수/짝수 분류]");
Console.Write($"홀수 ({oddIdx}개) : ");
for (int i = 0; i < oddIdx; i++) {
    Console.Write($"{(i == 0 ? "" : ", ")}{oddArr[i]}");
} Console.WriteLine();

Console.Write($"짝수 ({evenIdx}개) : ");
for (int i = 0; i < evenIdx; i++) {
    Console.Write($"{(i == 0 ? "" : ", ")}{evenArr[i]}");
} Console.WriteLine();
Console.WriteLine();

Console.WriteLine("[절댓값 10 이상]");
for (int i = 0; i < absOver10Idx; i++) {
    Console.Write($"{(i == 0 ? "" : ", ")}{absOver10Arr[i]}");
} Console.WriteLine();
Console.WriteLine();