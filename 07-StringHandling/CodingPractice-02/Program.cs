using System;
using System.Text;
using System.Diagnostics;

{
    // 1-1. Substring()
    string myStr = "Hello, World!";
    Console.WriteLine($"7번 이후 : {myStr.Substring(7)}");
    Console.WriteLine($"처음 5 글자 : {myStr.Substring(0, 5)}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 1-2. Replace()
    string myStr = "Hello, World!";
    Console.WriteLine(myStr.Replace("World", "C#"));
    Console.WriteLine(myStr.Replace("Hello", "안녕")
                      .Replace("World", "세계"));
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 1-3. Remove()
    string myStr = "Hello, World!";
    Console.WriteLine(myStr.Remove(5, 7));
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 1-4. Insert()
    string myStr = "Hello World";
    Console.WriteLine(myStr.Insert(5, ","));
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 2-1.Split();
    string myStr = "Red,Green,Blue";
    string[] splited = myStr.Split(",");
    foreach (string str in splited) Console.WriteLine(str);
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 2-2. 문자열과 문자 배열 반환
    string myStr = "Hello";
    char[] charArr = myStr.ToCharArray();
    foreach (char c  in charArr) Console.Write(c);
    Console.WriteLine(new String(charArr));
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 3-1. IsNullOrEmpty();
    string nullStr = null;
    string emptyStr = default;
    string normalStr = "Hello";
    Console.WriteLine($"str1 검사 : {String.IsNullOrEmpty(nullStr)}");
    Console.WriteLine($"str2 검사 : {String.IsNullOrEmpty(emptyStr)}");
    Console.WriteLine($"str3 검사 : {String.IsNullOrEmpty(normalStr)}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 3-2. IsNullOrWhiteSpace()
    string str1 = "";
    string str2 = " ";
    string str3 = "Hello";
    Console.WriteLine($"빈 문자열 : {String.IsNullOrWhiteSpace(str1)}");
    Console.WriteLine($"공백만 : {String.IsNullOrWhiteSpace(str2)}");
    Console.WriteLine($"텍스트 : {String.IsNullOrWhiteSpace(str3)}");
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 4-1. 문자열 연결의 문제점
    String ab = "";
    for (int i = 0; i < 4; i++)
    {
        ab+= $"항목{i} ";
    }
    Console.WriteLine(ab);
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 4-2. StringBuilder 사용법
    StringBuilder sb = new StringBuilder();
    sb.Append("January\n");
    sb.Append("Febuary\n");
    sb.AppendLine("March");
    Console.Write(sb);
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 4-3. StringBuilder 주요 메서드
    StringBuilder sb = new StringBuilder();
    sb.Append("Hello");
    sb.Append(" ");
    sb.Append("World");
    sb.AppendLine("!");
    sb.AppendFormat("숫자 : {0}", 123);
    sb.Replace("World", "C#");
    Console.WriteLine(sb);
    Console.WriteLine();
    Console.WriteLine();
}

{
    // 4-4. 메서드 체이닝
    StringBuilder sb = new StringBuilder()
                       .Append("StringBuilder를 사용한 ")
                       .Append("메서드 ")
                       .Append("체이닝");
    Console.WriteLine(sb.ToString());
    Console.WriteLine();
    Console.WriteLine();
}
Console.WriteLine();