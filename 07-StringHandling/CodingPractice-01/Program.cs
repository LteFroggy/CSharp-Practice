using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

{
    // 1-1 string과 String의 관계
    string smallStr = "안녕하세요.";
    String bigStr = "반갑습니다.";

    Console.WriteLine($"{smallStr} {bigStr}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 1-2. 문자열의 불변성
    string original = "Hello";
    string modified = original.ToUpper();

    Console.WriteLine($"원본 : {original}");
    Console.WriteLine($"수정 : {modified}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 2-1. 문자 배열에서 문자열 생성
    char[] charArr = { 'A', 'B', 'C' };
    string myStr = new string(charArr);

    Console.WriteLine($"{myStr}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 2-2. 빈 문자열 초기화
    string emptyStr = "";
    string emptyStr2 = string.Empty;
    Console.WriteLine($"빈 문자열 길이 : {emptyStr.Length}");
    Console.WriteLine($"빈 문자열 길이 : {emptyStr2.Length}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 3-1. Length 속성
    string str1 = "Hello.";
    string str2 = "안녕하세요.";

    Console.WriteLine($"s1 길이 : {str1.Length}");
    Console.WriteLine($"s1 길이 : {str2.Length}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 3-2. 인덱서를 통한 문자 접근
    string str = "Hello";
    
    Console.WriteLine($"첫 번째 문자 : {str[0]}");
    Console.WriteLine($"마지막 문자 : {str[str.Length - 1]}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 4-1. 덧셈 연산자 사용
    string lastName = "홍";
    string firstName = "길동";
    Console.WriteLine($"이름 : {lastName + firstName}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 4-2. String.Concat() 메서드
    string str1 = "안녕";
    string str2 = "하세요";
    string str3 = "a";
    string str4 = "b";
    string str5 = "c";
    string str6 = "d";
    Console.WriteLine($"{String.Concat(str1, str2)}");
    Console.WriteLine($"{String.Concat(str3, str4, str5, str6)}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 4-3. String.Join() 메서드
    string[] strArr = { "사과", "바나나", "오렌지" };
    Console.WriteLine(String.Join(", ", strArr));
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 5-1. 기본 보간법
    string lastName = "홍";
    string firstName = "길동";
    int int1 = 10;
    int int2 = 20;
    Console.WriteLine($"이름 : {lastName}{firstName}");
    Console.WriteLine($"{int1} + {int2} = {int1 + int2}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 5-2. 서식 지정
    int myInt = 1234567;
    double myDouble = 9999.99;
    DateTime date = DateTime.Now;
    int hexInt = 255;
    Console.WriteLine($"세 자리 구분 : {myInt:N0}");
    Console.WriteLine($"통화 형식 : {myDouble:C}");
    Console.WriteLine($"날짜 형식: {date:yyyy-mm-dd}");
    Console.WriteLine($"16진수: {hexInt:X}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 5-3. String.Format() 메서드
    string name = String.Format("{0}{1}", "홍", "길동");
    int myInt = 1000;
    int myInt2 = 1000000;
    Console.WriteLine(name);
    Console.WriteLine(String.Format("{0:C}", myInt));
    Console.WriteLine(String.Format("{0:N0}", myInt2));
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 6. 대소문자 변환
    string myStr = "Hello, World!";
    Console.WriteLine($"대문자 : {myStr.ToUpper()}");
    Console.WriteLine($"대문자 : {myStr.ToLower()}");
    Console.WriteLine($"대문자 : {myStr}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 7. 공백 처리
    string originalStr = "   Hello, World!   ";
    Console.WriteLine($"원본 : [{originalStr.Trim()}]");
    Console.WriteLine($"Trim : [{originalStr.Trim()}]");
    Console.WriteLine($"TrimStart : [{originalStr.TrimStart()}]");
    Console.WriteLine($"TrimEnd : [{originalStr.TrimEnd()}]");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 8-1. IndexOf()와 LastIndexOf()
    string myStr = "Hello, World!";
    Console.WriteLine($"첫 번째 'o' 위치 : {myStr.IndexOf('o')}");
    Console.WriteLine($"마지막 'o' 위치 : {myStr.LastIndexOf('o')}");
    Console.WriteLine($"'World' 위치 : {myStr.IndexOf("World")}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 8-2. Contains()
    string myStr = "Hello, World!";
    Console.WriteLine($"\"World\" 포함 : {myStr.Contains("World")}");
    Console.WriteLine($"\"world\" 포함 : {myStr.Contains("world")}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 8-3. StartsWith()와 EndsWith()
    string address = "https://www.example.com";
    Console.WriteLine($"https로 시작 : {address.StartsWith("https")}");
    Console.WriteLine($".com으로 종료 : {address.EndsWith(".com")}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 9-1. == 연산자
    string str1 = "Hello";
    string str2 = "Hello";
    string str3 = "hello";

    Console.WriteLine($"s1 == s2 : {str1 == str2}");
    Console.WriteLine($"s1 == s3 : {str1 == str3}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 9-2. Equals() 메서드 - 대소문자 무시
    string str1 = "Gilbut";
    string str2 = "gilbut";
    
    Console.WriteLine($"{(str1 == str2 ? "같다" : "다르다")}");
    Console.WriteLine((str1.Equals(str2, StringComparison.OrdinalIgnoreCase) ? "대소문자 무시하면 같다" : "대소문자 무시해도 다르다"));
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 9-3. String.Compare() 메서드
    string str1 = "A", str2 = "C", str3 = "A";
    Console.WriteLine($"A와 C 비교 : {String.Compare(str1, str2)}");
    Console.WriteLine($"C와 A 비교 : {String.Compare(str2, str1)}");
    Console.WriteLine($"A와 A 비교 : {String.Compare(str1, str3)}");
    Console.WriteLine();
    Console.WriteLine();
}


Console.WriteLine();