using System;

int sum = default, count = default;

sum += 10;
Console.WriteLine($"{count++}번째 숫자 10추가 : 합계 = {sum}");
sum += 20;
Console.WriteLine($"{count++}번째 숫자 20추가 : 합계 = {sum}");
sum += 30;
Console.WriteLine($"{count++}번째 숫자 30추가 : 합계 = {sum}");
sum += 40;
Console.WriteLine($"{count++}번째 숫자 40추가 : 합계 = {sum}");
sum += 50;
Console.WriteLine($"{count++}번째 숫자 50추가 : 합계 = {sum}");
Console.WriteLine("---");
Console.WriteLine($"총 {count}개 숫자의 합계 : {sum}");
Console.WriteLine();
Console.WriteLine();