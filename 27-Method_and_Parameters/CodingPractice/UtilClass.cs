using System;
using System.Net.Http.Headers;

class UtilClass {
    public static void ChangeValue(int value) {
        value += 10;
        Console.WriteLine($"[2] 메서드 내부 : {value}");
    }
    public static void ChangeRef(ref int value) {
        value += 10;
        Console.WriteLine($"[2] 메서드 내부 : {value}");
    }

    public static void PassByValue(int value) {
        value += 10;
        Console.WriteLine($"PassByValue 내부에서 수정된 값 : {value}");
    }

    public static void PassByReference(ref int value) {
        value += 10;
        Console.WriteLine($"PassByReference 내부에서 수정된 값 : {value}");
    }
    public static void Swap(ref int a, ref int b) {
        int temp = a;
        a = b;
        b = temp;
    }    
    public static void SplitName(string input, out string firstName, out string lastName) {
        lastName = input.Substring(0, 1);
        firstName = input.Substring(1);
    }
    public static int SumAll(params int[] value) {
        int sum = 0;
        foreach (int i in value) {
            sum += i;
            // Console.WriteLine(sum);
        }

        return sum;
    }
    public static void PrintMessage(string label, params int[] args) {
        int sum = 0;
        foreach (int arg in args) { sum += arg; }
        Console.WriteLine($"{label} : {sum}");
    }
    public static void Add(int a, int b = 1) => Console.WriteLine(a + b);
    public static void Square(int a) => Console.WriteLine(a * a);
    public static void Print(string str) => Console.WriteLine(str);
    public static void Greet(string name = "고객", string greeting = "환영합니다.") => Console.WriteLine($"{name}님, {greeting}");
    public static void PrintInfo(string name, int age, string city) {
        Console.WriteLine($"이름 : {name}, 나이 : {age}, 도시 : {city}");
    }
}