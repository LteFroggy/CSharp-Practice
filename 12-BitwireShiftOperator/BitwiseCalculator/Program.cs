using System;

int a = default, b = default;
while (true) {
    Console.Write("첫 번째 수를 입력하세요 : ");
    string tmp = Console.ReadLine();
    try {
        a = int.Parse(tmp);
    } catch {
        Console.WriteLine("올바른 숫자를 입력해주세요 : ");
        continue;
    }
    break;
}

while (true) {
    Console.Write("첫 번째 수를 입력하세요 : ");
    string tmp = Console.ReadLine();
    try {
        b = int.Parse(tmp);
    } catch {
        Console.WriteLine("올바른 숫자를 입력해주세요 : ");
        continue;
    }
    break;
}

Console.WriteLine($"--- 비트 연산 결과 ---");
Console.WriteLine($"x\t= {a} (0b{Convert.ToString(a, 2).PadLeft(8, '0')})");
Console.WriteLine($"x\t= {b} (0b{Convert.ToString(b, 2).PadLeft(8, '0')})");
Console.WriteLine();
Console.WriteLine($"x & y\t= {a & b} (0b{Convert.ToString(a & b, 2).PadLeft(8, '0')})");
Console.WriteLine($"x | y\t= {a | b} (0b{Convert.ToString(a | b, 2).PadLeft(8, '0')})");
Console.WriteLine($"x ^ y\t= {a ^ b} (0b{Convert.ToString(a ^ b, 2).PadLeft(8, '0')})");
Console.WriteLine($"~x\t= {~a}");
Console.WriteLine();
Console.WriteLine();