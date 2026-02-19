using System;
using System.Reflection.Emit;

Console.Write("줄 수를 입력하세요 : ");
int lineCount = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < lineCount; i++) {
    for (int j = 0; j <= i; j++) {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < lineCount; i++) {
    for (int j = 0; j <= lineCount - i; j++)
        Console.Write(" ");
    for (int j = 0; j <= i; j++) {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine(" 크리스마스 트리 만들기 ");
for (int i = 0; i < lineCount; i++) {
    for (int j = 0; j < lineCount - i; j++) {
        Console.Write(" ");
    }

    for (int j = 0; j < i; j++) {
        Console.Write("*");
    }

    Console.Write('*');

    for (int j = 0; j < i; j++) {
        Console.Write("*");
    }

    Console.WriteLine();
}


/// SnowFlake