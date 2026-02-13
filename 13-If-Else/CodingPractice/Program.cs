using System;

// 1. 순차문
{
    int kor = 100, eng = 90;
    int tot = kor + eng;
    double avg = tot / 2.0;
    Console.WriteLine($"총점 : {tot}");
    Console.WriteLine($"평균 : {avg:F1}");
    Console.WriteLine();
    Console.WriteLine();
}

// 2-1. 합격 판정
{
    int score = 60;
    if (score >= 60) { Console.WriteLine("합격"); } 
    else { Console.WriteLine("불합격"); }
    Console.WriteLine();
    Console.WriteLine();
}

// 2-2. 다양한 비교 연산자 사용
{
    int x = 10;
    if (x == 10) { Console.WriteLine($"x는 10입니다"); }
    if (x != 20) { Console.WriteLine("x는 20이 아닙니다.");  }
    Console.WriteLine();
    Console.WriteLine();
}

// 2-3. 조건이 거짓인 경우
{
    int score = 50;
    if (score >= 60) { Console.WriteLine("합격"); }
    Console.WriteLine("프로그램 종료");
    Console.WriteLine();
    Console.WriteLine();
}


// 3-1. 합격/불합격 판정
{
    int score = 59;
    if (score >= 60) { Console.WriteLine("합격"); } 
    else { Console.WriteLine("불합격");  }
    Console.WriteLine();
    Console.WriteLine();
}

// 3-2. 상수 비교
{
    const double k_Pi = 3.14;
    if (k_Pi == 3.14) { Console.WriteLine("PI는 3.14입니다"); } 
    else { Console.WriteLine("PI는 3.14가 아닙니다."); }
    Console.WriteLine();
    Console.WriteLine();
}

// 4-1. 두 수 비교
{
    int number1 = 10, number2 = 20;
    if (number1 > number2) { Console.WriteLine("number1이 더 큽니다"); } 
    else if (number1 < number2) { Console.WriteLine("number2가 더 큽니다"); } 
    else { Console.WriteLine("둘 다 같습니다."); }
}

// 4-2. 양수/음수/0 판별
{
    int number = -10;
    if (number > 0) { Console.WriteLine($"{number}은(는) 양수입니다"); } 
    else if (number < 0) { Console.WriteLine($"{number}은(는) 음수입니다"); } 
    else { Console.WriteLine($"{number}은(는) 0입니다"); }
    Console.WriteLine();
    Console.WriteLine();
}

// 4-3. 점수에 따른 학점 계산
{
    int score = 85;
    char grade = default;
    if (score >= 90) { grade = 'A'; }
    else if (score >= 80) { grade = 'B'; }
    else if (score >= 70) { grade = 'C'; }
    else if (score >= 60) { grade = 'D'; }
    else grade = 'F';
    Console.WriteLine($"점수 : {score}점");
    Console.WriteLine($"학점 : {grade}");
    Console.WriteLine();
    Console.WriteLine();
}

// 5-1. 중첩 if문 사용
{
    string name = "C#";
    int version = 10;
    if (name == "C#") {
        if (version >= 9) {
            Console.WriteLine($"{name} {version}은 최신 버전입니다.");
        }
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 5-2. 논리 연산자로 대체
{
    string name = "C#";
    int version = 10;
    if (name == "C#" 
        && version >= 9) {
        Console.WriteLine($"{name} {version}은 최신 버전입니다.");
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 6-1. 논리 AND 연산자
{
    int number = 1234;
    if (number == 1234 && number >= 1000) { Console.WriteLine("맞습니다"); }
    Console.WriteLine();
    Console.WriteLine();
}

// 6-2. OR 연산자
{
    int number = 1234;
    if (number == 1234 || number >= 1000) { Console.WriteLine("하나라도 참이면 참"); }
    Console.WriteLine();
    Console.WriteLine();
}

// 7. 짝수/홀수 판별 예제
{
    int a = 15;
    // 1
    if (a % 2 == 0) { Console.WriteLine("짝수"); }


    if (a % 2 == 1) { Console.WriteLine("홀수"); }
    else { Console.WriteLine("짝수"); }

    if (a % 3 == 0) { Console.WriteLine("3의 배수"); }
    else if (a % 5 == 0) { Console.WriteLine("5의 배수"); }
    else if (a % 7 == 0) { Console.WriteLine("7의 배수"); }
    else { Console.WriteLine("3, 5, 7의 배수가 아닌 수"); }
    Console.WriteLine();
    Console.WriteLine();
}