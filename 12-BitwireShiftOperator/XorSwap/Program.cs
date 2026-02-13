using System;

Console.WriteLine("=== XOR 값 교환 ===");

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
    Console.Write("두 번째 수를 입력하세요 : ");
    string tmp = Console.ReadLine();
    try {
        b = int.Parse(tmp);
    } catch {
        Console.WriteLine("올바른 숫자를 입력해주세요 : ");
        continue;
    }
    break;
}

Console.WriteLine($"교환 전 : a = {a}, b = {b}");
Console.WriteLine();
Console.WriteLine($"--- 교환 과정 ---");
Console.WriteLine($"1단계 : a = a ^ b"); // a = a ^ b
Console.WriteLine($"\ta = {a} ^ {b} = {a ^ b}");
Console.WriteLine();
a ^= b;

Console.WriteLine($"2단계 : b = a ^ b"); // b = a ^ b ^ b
Console.WriteLine($"\tb = {a} ^ {b} = {a ^ b}");
Console.WriteLine();
b ^= a;

Console.WriteLine($"3단계 : a = a ^ b"); // a = a ^ b ^ b ^ a ^ b
Console.WriteLine($"\ta = {a} ^ {b} = {a ^ b}");
Console.WriteLine();
a ^= b;

Console.WriteLine($"교환 후 : a = {a}, b = {b}");
Console.WriteLine();
Console.WriteLine();