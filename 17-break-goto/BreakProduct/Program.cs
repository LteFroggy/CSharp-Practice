using System;

int val = 1;
int sum = 1;
const int k_MaxVal = 1000;

while (true) {
    sum *= ++val;
    if (sum > k_MaxVal) { break; }
}

Console.WriteLine($"2부터 {val}까지의 곱 : {sum}");
Console.WriteLine($"(곱이 {k_MaxVal}을 초과함)");
