using System;

string[] students = { "김민수", "이지영", "박서준" };
int count = 0;

Console.WriteLine($"=== 초기 배치 ===");
for (int i = 0; i < students.Length; i++) { Console.Write($"{(i == 0 ? "" : ", ")}{i + 1}번 : {students[i]}"); }
Console.WriteLine();
Console.WriteLine();

int firstIdx, secondIdx;
firstIdx = 1; secondIdx = 2;
Console.WriteLine($"[교환] {firstIdx - 1}번 <-> {secondIdx - 1}번");
SwapClass.SwapSeats(ref students[firstIdx - 1], ref students[secondIdx - 1]);
SwapClass.CountSwap(ref count);
for (int i = 0; i < students.Length; i++) { Console.Write($"{(i == 0 ? "" : ", ")}{i + 1}번 : {students[i]}"); }
Console.WriteLine();
Console.WriteLine();

firstIdx = 2; secondIdx = 3;
Console.WriteLine($"[교환] {firstIdx - 1}번 <-> {secondIdx - 1}번");
SwapClass.SwapSeats(ref students[firstIdx - 1], ref students[secondIdx - 1]);
SwapClass.CountSwap(ref count);
for (int i = 0; i < students.Length; i++) { Console.Write($"{(i == 0 ? "" : ", ")}{i + 1}번 : {students[i]}"); }
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"=== 최종 결과 ===");
for (int i = 0; i < students.Length; i++) { Console.Write($"{(i == 0 ? "" : ", ")}{i + 1}번 : {students[i]}"); }
Console.WriteLine();
Console.WriteLine($"총 교환 횟수 : {count}회");
