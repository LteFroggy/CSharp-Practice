using System;

int[] data = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
bool[] isCounted = new bool[data.Length];

Console.WriteLine($" 값 | 빈도");
Console.WriteLine($"----|----");

for (int i = 0; i < data.Length; i++) {
    // 세지 않은 숫자 있다면 세기
    if (!isCounted[i]) {
        int target = data[i];
        int count = 0;
        for (int j = i; j < data.Length; j++) {
            if (data[j] == target) { 
                count++;
                isCounted[j] = true;
            }
        }

        Console.WriteLine($" {target, 2} | {count, 2}");
    }

}