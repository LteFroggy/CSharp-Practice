using System;

int idx = 21;

Console.Write($"20부터 1까지 (3의 배수 제외 : ");
for (int i = 20; i > 0; i--) {
    if (i % 3 == 0) { continue; }
    Console.Write($"{i} ");
}
Console.WriteLine();
Console.WriteLine();
