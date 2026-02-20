using System;

// 콜라즈 추측
int n = 27;

Console.WriteLine($"시작 : {n}");
int count = 0;

while (n != 1 && ++count != 0) {
    Console.Write($"{n} -> ");
    if (n % 2 == 0) {
        n /= 2;
    } else {
        n *= 3;
        n++;
    }
}
Console.WriteLine(n);

Console.WriteLine($"총 {count}단계 만에 {n}에 도달했습니다.");