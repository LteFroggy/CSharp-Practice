using System;

static int LinearSearch(in int[] data, in int target) {
    int idx = -1;
    for (int i = 0; i < data.Length; i++) {
        if (data[i] == target) {
            idx = i;
            break;
        }
    }

    return idx;
}
static int BinarySearch(in int[] data, in int target) {
    int low = 0, high = data.Length - 1, mid;
    int idx = -1;
    while (low <= high) {
        mid = (low + high) >> 1;
        if (data[mid] == target) { 
            idx = mid;
            break;
        } else if (data[mid] < target) {
            low = mid + 1;
        } else {
            high = mid - 1;
        }
    }
    return idx;
}


int[] data = { 38, 27, 43, 3, 9, 82, 10 };

Console.WriteLine($"=== 버블 정렬과 검색 ===");
Console.WriteLine($"[1] 원본 배열");
foreach ( int i in data ) { Console.Write($"{i} "); }
Console.WriteLine();
Console.WriteLine();

int count = 0;
for (int i = data.Length - 1; i >= 0; i--) {
    for (int j = 0; j < i; j++) {
        if (data[j] > data[j + 1]) {
            count++;
            int temp = data[j];
            data[j] = data[j + 1];
            data[j + 1] = temp;
        }
    }
}
Console.WriteLine($"[2] 버블 정렬 (교환 {count}회)");
foreach ( int i in data ) { Console.Write($"{i} "); }
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"[3] 순차 검색");
int target = 43;
int idx = LinearSearch(data, target);
Console.WriteLine($"{target} 검색 : {(idx == -1 ? "찾지 못함" : $"{idx}번 인덱스에서 찾음")}");
target = 50;
idx = LinearSearch(data, target);
Console.WriteLine($"{target} 검색 : {(idx == -1 ? "찾지 못함" : $"{idx}번 인덱스에서 찾음")}");
Console.WriteLine();

Console.WriteLine($"[4] 이진 검색");
target = 43;
idx = BinarySearch(data, target);
Console.WriteLine($"{target} 검색 : {(idx == -1 ? "찾지 못함" : $"{idx}번 인덱스에서 찾음")}");
target = 50;
idx = BinarySearch(data, target);
Console.WriteLine($"{target} 검색 : {(idx == -1 ? "찾지 못함" : $"{idx}번 인덱스에서 찾음")}");
Console.WriteLine();