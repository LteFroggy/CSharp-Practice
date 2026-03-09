using System;
using System.Reflection.Metadata.Ecma335;

class MathUtils {
    public static int Square(int n) => n * n;
    public static int Cube(int n) => n * n * n;
    public static bool IsEven(int n) => n % 2 == 0;
    public static bool IsPositive(int n) => n > 0;
    public static int Abs(int n) => n < 0 ? n * -1 : n;
    public static int Clamp(int n, int min, int max) => (n < min ? min : (n > max ? max : n));
}