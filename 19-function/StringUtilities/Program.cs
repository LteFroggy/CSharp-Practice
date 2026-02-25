using System;

class StringUtil {
    public string Reverse(string text) {
        string result = "";
        foreach (char c in text) { result = c + result; }
        return result;
    }

    public int CountWords(string text) {
        return text.Split(' ').Length; 
    }

    public bool IsPalindrome(string text) {
        // 대소문자 삭제
        text = text.ToLower();
        // 공백 제거
        string[] splited = text.Split(' ', '\n', '\t');
        string newText = "";
        foreach (string str in splited) { newText += str; }

        bool palindromeFlag = true;
        int left = 0, right = newText.Length - 1;

        while (left <= right) {
            if (newText[left] != newText[right]) {
                palindromeFlag = false;
                break;
            }

            left++; right--;
        }

        return palindromeFlag;
    }
    public string Capitalize(string text) {
        string newStr = "";
        bool capFlag = true;
        for (int i = 0; i < text.Length; i++) {
            if (capFlag) {
                newStr += (text[i] >= 'a' && text[i] <= 'z') ? (char)(text[i] - ('a' - 'A')) : text[i];
                capFlag = false;
            } else {
                newStr += text[i];
            }

            if (text[i] == ' ') { capFlag = true; }
        }

        return newStr;
    }
    public string RemoveDuplicateSpaces(string text) {
        string newStr = "";
        bool continousFlag = false;
        foreach (char c in text) {
            if (c == ' ') {
                if (continousFlag) { continue; }
                continousFlag = true;
            } else {
                continousFlag = false;
            }

            newStr += c;
        }

        return newStr;
    }
}
class Program {
    public static void Main(string[] args) {
        string str = "";
        StringUtil stringUtil = new StringUtil();
        Console.WriteLine($"=== 문자열 유틸리티 테스트 ===");

        Console.WriteLine($"[Reverse 테스트]");
        str = "Hello world";
        Console.WriteLine($"원본 : {str}");
        Console.WriteLine($"결과 : {stringUtil.Reverse(str)}");
        Console.WriteLine();

        Console.WriteLine($"[CountWords 테스트]");
        str = "The quick brown fox jumps over the lazy dog";
        Console.WriteLine($"원본 : {str}");
        Console.WriteLine($"결과 : {stringUtil.CountWords(str)}");
        Console.WriteLine();

        Console.WriteLine($"[IsPalindrome 테스트]");
        str = "level";
        Console.WriteLine($"{str} -> {stringUtil.IsPalindrome(str)}");
        str = "hello";
        Console.WriteLine($"{str} -> {stringUtil.IsPalindrome(str)}");
        str = "A man a plan a canal Panama";
        Console.WriteLine($"{str} -> {stringUtil.IsPalindrome(str)}");
        Console.WriteLine();

        Console.WriteLine($"[Capitalize 테스트]");
        str = "hello world example";
        Console.WriteLine($"원본 : {str}");
        Console.WriteLine($"결과 : {stringUtil.Capitalize(str)}");
        Console.WriteLine();

        Console.WriteLine($"[RemoveDuplicateSpaces 테스트]");
        str = "Hello    World   Example";
        Console.WriteLine($"원본 : {str}");
        Console.WriteLine($"결과 : {stringUtil.RemoveDuplicateSpaces(str)}");
        Console.WriteLine();
    }
}