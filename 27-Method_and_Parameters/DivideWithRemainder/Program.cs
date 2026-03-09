using System;
int num1, num2;
int result1, result2;

num1 = 17; num2 = 5;
Divider.Divide(num1, num2, out result1, out result2);
Console.WriteLine($"{num1} / {num2} = 몫 : {result1}, 나머지 : {result2}");

num1 = 25; num2 = 7;
Divider.Divide(num1, num2, out result1, out result2);
Console.WriteLine($"{num1} / {num2} = 몫 : {result1}, 나머지 : {result2}");

num1 = 100; num2 = 3;
Divider.Divide(num1, num2, out result1, out result2);
Console.WriteLine($"{num1} / {num2} = 몫 : {result1}, 나머지 : {result2}");
