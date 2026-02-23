using System;

const int k_Max = 100;
const int k_BoundaryFloor = 30;
const int k_BoundaryCeiling = 60;

int sum = 0;
int excludedCount = 0;
for (int i = 1; i <= k_Max; i++) {
    if (i >= k_BoundaryFloor && i <= k_BoundaryCeiling) { 
        excludedCount++;
        continue;
    }
    sum += i;
}

Console.WriteLine($"1 ~ {k_Max} 중 {k_BoundaryFloor} ~ {k_BoundaryCeiling}범위 제외 : ");
Console.WriteLine($"제외된 숫자 갯수 : {excludedCount}");
Console.WriteLine($"나머지 숫자의 합 : {sum}");
