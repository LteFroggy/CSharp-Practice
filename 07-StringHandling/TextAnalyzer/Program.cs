using System;

Console.WriteLine("아무 문장이나 입력하세요 : ");
string userInput = Console.ReadLine();

/// 전체 문자 수
/// 전체 문자 길이 세기
int charCount = userInput.Length;

/// 공백 제외 전체 문자 수
/// 공백 기준 split 후 갯수 세기
string[] userInputSplited = userInput.Split('\t', '\n', ' ');
int charCountExceptWhiteSpace = default;
foreach (string s in userInputSplited) charCountExceptWhiteSpace += s.Length;

/// 단어 개수
/// Split된 배열의 개수 세기
int wordCount = userInputSplited.Length;

/// 대, 소문자, 숫자 개수
/// 문자 하나씩 보면서 확인
int upperCaseCount = default, lowerCaseCount = default, numberCount = default;
foreach (char c in userInput)
{
    if (c >= 'A' && c <= 'Z') upperCaseCount++;
    else if (c >= 'a' && c <= 'z') lowerCaseCount++;
    else if (c >= '0' && c <= '9') numberCount++;
}

// 출력
Console.WriteLine($"=== 텍스트 분석 결과 ===");
Console.WriteLine($"전체 문자 수 (공백 포함) : {charCount}");
Console.WriteLine($"전체 문자 수 (공백 제외): {charCountExceptWhiteSpace}");
Console.WriteLine($"단어 개수 : {wordCount}");
Console.WriteLine($"대문자 개수 : {upperCaseCount}");
Console.WriteLine($"소문자 개수 : {lowerCaseCount}");
Console.WriteLine($"숫자 개수 : {numberCount}");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"검색할 문자를 입력하세요 : ");

char target = (char)Console.Read();
int foundedLoc = userInput.IndexOf(target);
Console.WriteLine($"'{target}' 문자가 포함되어 {(foundedLoc != -1 ? $"있습니다. (첫 번째 위치 : {foundedLoc})" : $"있지 않습니다.")}");