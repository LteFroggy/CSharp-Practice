using System;

int n = 12345;
int sum = 0;
int temp = n;

while (temp != 0) {
    // 일의 자리 추출 1234 -> 4
    sum += (temp % 10);

    // 자리수 줄이기 1234 -> 123
    temp /= 10;
}

Console.WriteLine($"{n}의 자릿수 합 : {sum}");
