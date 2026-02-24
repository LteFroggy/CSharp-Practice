using System;

// README.md를 읽고 코드를 작성하세요.

Console.WriteLine();

int[] myArr = { 15, 8, 23, 42, 16, 8, 31 };
int target = 8;

Console.WriteLine("=== 배열 검색 프로그램 ===");
Console.WriteLine();

Console.WriteLine($"[배열 내용]");
for (int i = 0; i < myArr.Length; i++) {
    Console.Write($"[{i}]={myArr[i]} ");
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"[값 {target} 검색 - 첫 번째 위치]");
int count = 0;
for (int i = 0; i < myArr.Length; i++) {
    if (myArr[i] == target) {
        count++;
        Console.WriteLine($"값 {target}을 인덱스 {i}에서 찾았습니다.");
        break;
    }
}
if (count == 0) { Console.WriteLine($"값 {target}을 찾을 수 없습니다."); }
Console.WriteLine();


Console.WriteLine($"[값 {target} 검색 - 모든 위치]");
Console.Write($"값 {target}이 있는 위치 : ");
count = 0;
for (int i = 0; i < myArr.Length; i++) {
    if (myArr[i] == target) {
        count++;
        Console.Write($"{(count == 1 ? "" : ", ")}{i}");
    }
}
Console.WriteLine();
Console.WriteLine($"총 {count}개 발견");
Console.WriteLine();

Console.WriteLine($"[값 100 검색]");
target = 100; count = 0;
for (int i = 0; i < myArr.Length; i++) {
    if (myArr[i] == target) {
        Console.WriteLine($"값 {target}을 인덱스 {i}에서 찾았습니다.");
        break;
    }
}
if (count == 0) { Console.WriteLine($"값 {target}을 찾을 수 없습니다."); }