using System;


int[] myArr = new int[] {10, 20, 30, 40, 50};

Console.WriteLine("=== 배열 뒤집기 ===");
Console.WriteLine();
// 원본 배열 출력
Console.WriteLine($"[원본 배열]");
for (int i = 0; i < myArr.Length; i++) { Console.Write($"{myArr[i]} "); }
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"[역순 출력]");
for (int i = myArr.Length - 1; i > 0; i--) { Console.Write($"{myArr[i]} "); }
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("[배열 뒤집기 수행]");
int tmp;
for (int i = 0; i <= myArr.Length / 2; i++) {
    // Swap 과정 출력을 위함
    if (i != myArr.Length - i - 1) {
       Console.WriteLine($"{myArr[i]} <-> {myArr[myArr.Length - i - 1]}");
    }
    // Swap 과정
    tmp = myArr[i];
    myArr[i] = myArr[myArr.Length - i - 1];
    myArr[myArr.Length - i - 1] = tmp;
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"[뒤집힌 배열]");
for (int i = 0; i < myArr.Length; i++) { Console.Write($"{myArr[i]} "); }
Console.WriteLine();
Console.WriteLine();
