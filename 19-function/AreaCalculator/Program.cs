using System;

class Calculator {
    public double GetArea(double radius) {
        return radius * 3.14;
    }

    public int GetArea(int width, int height) {
        return width * height;
    }

    public double GetArea(double width, double height) {
        return width * height;
    }

    public double GetArea(double top, double bottom, double height) {
        return (top + bottom) * height / 2;
    }
}

class Program {
    public static void Main() {
        Calculator myCalc = new Calculator();
        Console.WriteLine($"=== 면적 계산기 ===");
        Console.WriteLine();
        Console.WriteLine($"[원]");
        Console.WriteLine($"반지름 5 -> 면적 : {myCalc.GetArea(5):F2}");
        Console.WriteLine($"반지름 10 -> 면적 : {myCalc.GetArea(10):F2}");
        Console.WriteLine();
        Console.WriteLine($"[직사각형 (정수)]");
        Console.WriteLine($"4 x 6 -> 면적 : {myCalc.GetArea(4, 6)}");
        Console.WriteLine($"7 x 3 -> 면적 : {myCalc.GetArea(7, 3)}");
        Console.WriteLine();
        Console.WriteLine($"[직사각형 (실수)]");
        Console.WriteLine($"4.5 x 6.2 -> 면적 : {myCalc.GetArea(4.5, 6.2):F2}");
        Console.WriteLine($"7.1 x 3.3 -> 면적 : {myCalc.GetArea(7.1, 3.3):F2}");
        Console.WriteLine();
        Console.WriteLine($"[사다리꼴]");
        Console.WriteLine($"윗변 3, 아랫변 5, 높이 4 -> 면적 : {myCalc.GetArea(3, 5, 4)}");
        Console.WriteLine($"윗변 6, 아랫변 10, 높이 5 -> 면적 : {myCalc.GetArea(6, 10, 5)}");
        Console.WriteLine();
        Console.WriteLine();
    }
}