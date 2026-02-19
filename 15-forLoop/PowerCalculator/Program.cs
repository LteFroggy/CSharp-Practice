using System;

Console.Write("밑을 입력하세요 : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("지수를 입력하세요 : ");
int b = Convert.ToInt32(Console.ReadLine());

int result = 1;

for (int i = 0; i < b; i++) { result *= a; }
Console.WriteLine($"{a}의 {b} 제곱 : {result}");