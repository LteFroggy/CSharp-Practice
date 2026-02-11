using System;

int x = 5;
Console.WriteLine($"초기 x : {x}");
int a = x++;
Console.WriteLine($"x++후 : x = {x}, a = {a}");
int b = ++x;
Console.WriteLine($"++x 후 : x = {x}, b = {b}");
int c = x--;
Console.WriteLine($"x-- 후 : x = {x}, c = {c}");
int d = --x;
Console.WriteLine($"--x 후 : x = {x}, d = {d}");
Console.WriteLine();
Console.WriteLine();