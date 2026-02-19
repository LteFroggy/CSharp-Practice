using System;

Console.Write($"시작 단을 입력하세요 : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"끝 단을 입력하세요 : ");
int b = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= 9; i++) {
    for (int j = a; j <= b; j++) {
        if (i == 0) { Console.Write($"    {j}단\t\t"); }
        else { Console.Write($"{j} * {i} = {j * i, 2}\t"); }
    }
    Console.WriteLine();
}

Console.WriteLine();