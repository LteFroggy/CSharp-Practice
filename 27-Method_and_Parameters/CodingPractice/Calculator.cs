using System;

class Calculator{
    public int Add(int a, int b) {
        return a + b;
    }

    public static void Calculate(out int result) {
        result = 1234;
        Console.WriteLine($"메서드 내부 : {result}");
    }
}
