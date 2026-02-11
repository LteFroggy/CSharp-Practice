using System;

int num = 276;

Console.WriteLine($"원래 숫자 : {num}");
Console.WriteLine($"백의 자리 : {num / 100}");
Console.WriteLine($"십의 자리 : {num % 100 / 10}");
Console.WriteLine($"일의 자리 : {num % 10}");
Console.WriteLine($"자릿수 합 : {num / 100 + num / 10 + num % 10}");
Console.WriteLine($"자릿수 곱 : {(num / 100) * (num / 1) * (num % 10)}");
Console.WriteLine($"뒤집은 숫자 : {(num % 10 * 100) + (num % 100 / 10 * 10) + (num / 100)}");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();