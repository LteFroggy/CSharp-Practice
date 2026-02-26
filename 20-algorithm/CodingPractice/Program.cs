using System;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

// 1-1 기본 합계
{
    int[] intArr = {10, 20, 30, 40, 50};
    int sum  = 0;
    foreach (int i in intArr) { sum += i; }
    Console.WriteLine($"합계 : {sum}");
    Console.WriteLine();
    Console.WriteLine();
}

// 1-2. 조건부 합계
{
    int[] scores = { 100, 75, 50, 37, 90, 95 };
    int sum = 0;
    foreach (int score in scores) { sum += (score >= 80 ? score : 0); }
    Console.WriteLine($"6명의 점수 중 80 점 이상의 총점 : {sum}");
    Console.WriteLine();
    Console.WriteLine();
}

// 2. 개수 알고리즘
{
    int[] numbers = {10, 9, 4, 7, 6, 5};
    int count = 0;
    foreach (int num in numbers) {
        if (num % 2 == 0) { count++; }
    }
    Console.WriteLine($"짝수의 개수 : {count}");
    Console.WriteLine();
    Console.WriteLine();
}

// 3-1. 전체 평균
{
    int[] scores = { 50, 65, 78, 90, 95 };
    int sum = 0;
    foreach (int score in scores) { 
        if (score >= 80 && score <= 95) { sum += score; }
    }
    double avg = (double)sum / scores.Length;
    Console.WriteLine($"80점 이상 95점 이하인 점수의 평균 : {avg:F1}");
    Console.WriteLine();
    Console.WriteLine();
}

// 4. 최댓값 알고리즘
{
    int[] numbers = { -2, -5, -3, -7, -1};
    int max = Int32.MinValue;
    foreach (int num in numbers) {
        if (max < num) { max = num; } 
    }
    Console.WriteLine($"최댓값 : -1");
    Console.WriteLine();
    Console.WriteLine();
}

// 5. 최솟값 알고리즘
{
    int[] numbers = { -2, -5, -3, -7, -1};
    int min = Int32.MaxValue;
    foreach (int num in numbers) {
        if (min < num) { min = num; } 
    }
    Console.WriteLine($"최댓값 : -1");
    Console.WriteLine();
    Console.WriteLine();
}

// 6. 근삿값 알고리즘
{
    int[] numbers = { 10, 20, 30, 27, 17 };
    int target = 25;
    int val = Int32.MinValue;
    foreach (int num in numbers) {
        if (Math.Abs(val - target) > Math.Abs(num - target)) {
            val = num;
        }
    }
    Console.WriteLine($"{target}에 가장 가까운 값 : {val}");
    Console.WriteLine();
    Console.WriteLine();
}

// 7. 순위 알고리즘
{
    int[] intArr = { 90, 87, 100, 95, 80 };
    int[] rank = new int[5];

    for (int i = 0; i < intArr.Length; i++) { 
        rank[i] = 1;
        for (int j = 0 ; j < intArr.Length; j++) {
            if (intArr[i] < intArr[j]) { rank[i]++; }
        }
    }

    for (int i = 0; i < intArr.Length; i++) {
        Console.WriteLine($"{intArr[i]}점 : {rank[i]}등");
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 8. 정렬 알고리즘
{
    int[] numbers = { 7, 5, 6, 1, 10 };

    // 버블 정렬
    for (int i = numbers.Length - 1; i > 0; i--) {
        for (int j = 0; j < i; j++) {
            if (numbers[j] > numbers[j + 1]) {
                int temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j  + 1] = temp;
            }
        }
    }
    Console.Write($"정렬 결과 : ");
    foreach (int num in numbers) {
        Console.Write($"{num} ");
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
}

// 9-1 순차 검색
{
    int[] numbers = { 3, 7, 1, 9, 5 };
    int target = 9;
    int idx = -1;
    for (int i = 0; i < numbers.Length; i++) {
        if (numbers[i] == target) {
            idx = i;
            break;
        }
    }
    Console.WriteLine($"{target}을(를) {idx}번 인덱스에서 찾음");
    Console.WriteLine();
    Console.WriteLine();
}

// 9-2. 이진 검색
{
    int[] numbers = { 1, 3, 5, 7, 9 };
    int idx = -1;
    int target = 7;
    int low = 0, high = numbers.Length - 1, mid = (low + high) / 2;
    while (low <= high) {
        mid = (low + high) / 2;
        // 발견했으면 바로 종료
        if (numbers[mid] == target) {
            idx = mid;
            break;
        }
        // 중간값이 목표보다 작으면, 오른쪽 확인
        else if (numbers[mid] < target) {
            low = mid + 1;
        } 
        // 중간값이 목표보다 크면, 왼쪽 확인
        else {
            high = mid - 1;
        }
    }
    Console.WriteLine($"{target}을(를) {idx}번 인덱스에서 찾음");
    Console.WriteLine();
    Console.WriteLine();
}

// 10. 병합 알고리즘
{
    int[] arr1 = { 1, 3, 5 };
    int[] arr2 = { 2, 4 };
    int[] sorted = new int[arr1.Length + arr2.Length];
    int lPtr = 0, rPtr = 0, sortedPtr = 0;
    while (sortedPtr < sorted.Length) {
        // 왼쪽 값 끝났으면, 오른쪽 값 넣기
        if (lPtr == arr1.Length) {
            sorted[sortedPtr++] = arr2[rPtr++];
        } 
        // 오른쪽 값 끝났으면, 왼쪽 값 넣기
        else if (rPtr == arr2.Length) {
            sorted[sortedPtr++] = arr1[lPtr++];
        }
        
        // 끝나지 않았으면, 대소비교해서 삽입
        else if (arr1[lPtr] < arr2[rPtr]) {   
            sorted[sortedPtr++] = arr1[lPtr++];
        } else {
            sorted[sortedPtr++] = arr2[rPtr++];
        }
    }

    Console.Write($"병합 결과 : ");
    foreach (int i in sorted) {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 11. IPO 구조
{
    // Input
    int[] scores = { 85, 90, 78, 92, 88 };

    // Process
    int sum = 0, max = Int32.MinValue, min = Int32.MaxValue;
    double avg = 0;
    foreach (int i in scores) { 
        sum += i;
        max = max < i ? i : max;
        min = min < i ? min : i;
    }
    avg = (double)sum / scores.Length;

    // Output
    Console.WriteLine($"합계 : {sum, 3}");
    Console.WriteLine($"평균 : {avg:F1}");
    Console.WriteLine($"최고점 : {max, 3}");
    Console.WriteLine($"최저점 : {min, 3}");
}