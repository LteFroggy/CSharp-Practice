using System;

int n = 12345;
int newInt = 0;

int tmp = n;
do {
    newInt *= 10;
    newInt += (tmp % 10);
    tmp /= 10;
} while (tmp != 0);

Console.WriteLine($"{n}을(를) 뒤집으면 : {newInt}");