using System;
using System.Collections.Immutable;

// 이름 입력받기
Console.Write("이름 목록을 쉼표로 구분하여 입력하세요 : ");
string userInput = Console.ReadLine();

// 쉼표 기준으로 나눠 저장 후, 공백 삭제
string[] inputToArr = userInput.Split(',');
for (int i = 0; i < inputToArr.Length; i++)
    inputToArr[i] = inputToArr[i].Trim();

// 1. 사전 순 정렬 후 출력
string[] ascArr = new string[inputToArr.Length];
Array.Copy(inputToArr, ascArr, inputToArr.Length);
Array.Sort(ascArr);
Console.WriteLine("[사전 순 정렬]");
for (int i = 0; i < ascArr.Length; i++) {
    if (i == ascArr.Length - 1)
        Console.Write($"{ascArr[i]}");
    else 
        Console.Write($"{ascArr[i]}, ");
}

Console.WriteLine();
Console.WriteLine();

// 2. 사전 역순 정렬 후 출력
Array.Reverse(ascArr);
Console.WriteLine("[사전 순 역정렬]");
for (int i = 0; i < ascArr.Length; i++)
{
    if (i == ascArr.Length - 1)
        Console.Write($"{ascArr[i]}");
    else
        Console.Write($"{ascArr[i]}, ");
}


