using System;
using System.Collections.Specialized;
using System.IO;

// 1-1. 기본 사용법
{
    for (int i = 0; i < 10; i++) {
        Console.WriteLine(i);
        if (i == 3) {
            break; 
        }
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 1-2. while문에서 break 사용
{
    int number = 0;
    while (true) {
        number++;
        Console.WriteLine(number);
        if (number >= 5) {
            break;
        }
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 1-3. 조건을 만족할 때까지 합계 구하기
{
    int sum = 0;
    int idx = 1;
    int goal = 22;
    while (sum < goal) {
        sum += idx;
        if (sum >= 22) {
            break;
        }

        idx++;
    }
    Console.WriteLine($"1부터 {idx}까지의 합 : {sum}");
    Console.WriteLine($"목표치 {goal} 이상 달성");
    Console.WriteLine();
    Console.WriteLine();
}

// 1-4. 중첩 반복문에서 break
{
    for (int i = 1; i < 4; i++) {
        for (int j = 1; j < 6; j++) {
            if (j == 3) {
                break;
            }
            Console.WriteLine($"외부 반복 : {j}");
        }
        Console.WriteLine($"내부 반복 : {i}");
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 2-1. 기본 사용법
{
    for (int i = 1; i < 6; i++) {
        if (i % 2 == 0) { continue; }
        Console.WriteLine(i);
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 2-2. 3의 배수를 제외한 합계
{
    int sum = 0;
    for (int i = 1; i < 101; i++) {
        if (i % 3 ==0 ) { continue; }
        sum += i;
    }
    Console.WriteLine($"1 ~ 100중 3의 배수 제외 합계 : {sum}");
    Console.WriteLine();
    Console.WriteLine();
}

// 2-3. 7의 배수를 제외한 합계
{
    int sum = 0;
    for (int i = 1; i < 101; i++) {
        if (i % 7 ==0 ) { continue; }
        sum += i;
    }
    Console.WriteLine($"1 ~ 100중 3의 배수 제외 합계 : {sum}");
    Console.WriteLine();
    Console.WriteLine();
}

// 2-4. while문에서 continue 사용
{
    int i = 0;
    while (i++ < 10) {
        if (i % 2 == 0) { continue; }
        Console.Write($"{i} ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 3. break와 continue 비교
{
    Console.WriteLine("=== break 예제 ===");
    for (int i = 1; i < 6; i++) {
        if (i == 3) { break; }
        Console.WriteLine(i);
    }
    Console.WriteLine();
    Console.WriteLine("=== continue 예제 ===");
    for (int i = 1; i < 6; i++) {
        if (i == 3) { continue; }
        Console.WriteLine(i);
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 4-1. 기본 사용법
{
    int i = 1;
    StartLoop:
    Console.WriteLine(i++);
    if (i <= 5) { goto StartLoop; }
    Console.WriteLine("종료");
    Console.WriteLine();
    Console.WriteLine();
}

// 4-2. 여러 레이블 사용
{
    Console.WriteLine("시작");
    Console.Write("1 또는 2를 입력하세요 : ");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a == 1) { goto Option1; }
    else if (a == 2) { goto Option2; }
    else { goto End; }


    Option1:
    Console.WriteLine($"옵션 1을 선택했습니다");
    goto End;

    Option2:
    Console.WriteLine($"옵션 2를 선택했습니다");
    goto End;

    End:
    Console.WriteLine("프로그램 종료");
    Console.WriteLine();
    Console.WriteLine();
}

// 4-3. switch문에서 goto case
{
    int card = 11;

    switch (card) {
        case 13:
            Console.WriteLine("King");
            break;
        case 12:
            Console.WriteLine("Queen");
            break;
        case 11:
            Console.WriteLine("Jack");
            goto case 12;
        case -1:
            goto default;
        default:
            Console.WriteLine("일반 카드");
            break;
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 4-4. goto 대신 플래그 변수 사용
{
    bool shouldExit = false;
    for (int i = 0; i < 3 && !shouldExit; i++) {
        for (int j = 0; j < 3 && !shouldExit; j++) {
            if (i == 1 && j == 1) shouldExit = true;
            Console.WriteLine($"i = {i}, j = {j}");
        }
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 5-1. 사용자 입력 유효성 검사
{
    int input;
    while (true) {
        Console.Write("1 ~ 10 사이의 숫자를 입력하세요 : ");
        
        if (!Int32.TryParse(Console.ReadLine(), out input)) {
            Console.WriteLine("숫자를 입력해주세요.");
            continue;
        }

        if (input < 0 || input > 10) {
            Console.WriteLine("범위를 벗어났습니다.");
            continue;
        }

        break;
    }

    Console.WriteLine($"입력한 숫자 : {input}");
    Console.WriteLine();
    Console.WriteLine();
}

// 5-2. 특정 값 찾기
{
    int[] myArr = {5, 12, 8, 23, 15, 42, 7};
    int target = 23;
    int foundedIdx = -1;
    for (int i = 0; i < myArr.Length; i++) {
        if (myArr[i] == target) {
            foundedIdx = i;
            break;
        }
    }
    Console.WriteLine($"{target}을(를) {foundedIdx}에서 찾음");
    Console.WriteLine();
    Console.WriteLine();
}

// 5-3. 양수만 합계 구하기
{
    int[] myArr = {3, -2, 7, -5, 4, -1, 9};
    int sum = 0;
    foreach (int val in myArr) {
        if (val < 0) { continue; }
        sum += val;
    }

    Console.WriteLine($"양수의 합계 : {sum}");
}