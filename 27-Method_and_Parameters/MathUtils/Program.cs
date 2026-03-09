using System;

Console.WriteLine($"5의 제곱 : {MathUtils.Square(5)}");
Console.WriteLine($"3의 제곱 : {MathUtils.Cube(3)}");
Console.WriteLine($"10은 짝수? : {MathUtils.IsEven(10)}");
Console.WriteLine($"-5는 양수? : {MathUtils.IsPositive(-5)}");
Console.WriteLine($"-7의 절댓값 : {MathUtils.Abs(-7)}");
int val1, val2, val3;
val1 = 15; val2 = 0; val3 = 10;
Console.WriteLine($"Clamp({val1}, {val2}, {val3}) : {MathUtils.Clamp(val1, val2, val3)}");

val1 = -5; val2 = 0; val3 = 10;
Console.WriteLine($"Clamp({val1}, {val2}, {val3}) : {MathUtils.Clamp(val1, val2, val3)}");

val1 = 5; val2 = 0; val3 = 10;
Console.WriteLine($"Clamp({val1}, {val2}, {val3}) : {MathUtils.Clamp(val1, val2, val3)}");

Console.WriteLine();
Console.WriteLine();