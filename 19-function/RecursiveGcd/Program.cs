using System;

class GCD {
    public int GcdLoop(int a, int b) {
        int tmp = a;
        while (b != 0) {
            a = b;
            b = tmp % b;
        }

        return a;
    }

    public int GcdRecursive(int a, int b) {
        return b == 0 ? a : GcdRecursive(b, a % b);
    }
}

class Program {
    public static void Main(string[] args) {
        GCD gcd = new GCD();
        int[] aList = { 12, 24, 17, 100, 48 };
        int[] bList = { 8, 36, 5, 75, 18 };

        Console.WriteLine($"=== 최대공약수 계산 ===");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"{'a', 3} {'b', 3}  | {"반복문", 3} | {"재귀", 3}");
        Console.WriteLine($"---------|--------|--------");
        
        for (int i = 0; i < aList.Length; i++) {
            Console.WriteLine($"{aList[i], 3}  {bList[i], 3} | {gcd.GcdLoop(aList[i], bList[i]), 6} | {gcd.GcdRecursive(aList[i], bList[i]), 4}");
        }
    }
}