using System;

int a = 10, b = 20, c = 30;
Console.WriteLine($"교환 전 : a = {a}, b = {b}, c = {c}");

// a - c 먼저 tmp를 통한 값 맞교환
int tmp = a; // tmp = 10
a = c;       // a = 30 fixed 
c = tmp;     // c = 10

// b - c tmp를 활용해 값 맞교환
tmp = b;     // tmp = 20
b = c;       // b = 10 fixed
c = tmp;     // c = 20 fixed
Console.WriteLine($"교환 후 : a = {a}, b = {b}, c = {c}");
Console.WriteLine();
Console.WriteLine();