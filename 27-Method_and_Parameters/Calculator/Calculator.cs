using System;

class Calculator {
    public static int Sum(params int[] values) {
        int sum = 0;
        foreach (int val in values) { sum += val; }
        return sum;
    }
    public static double Average(params int[] values) {
        int sum = Sum(values);
        return (double)sum / values.Length;
    }
    public static int Max(params int[] values) {
        int max = Int32.MinValue;
        foreach (int val in values) { max = (max < val ? val : max); }
        return max;
    }
    public static int Min(params int[] values) {
        int min = Int32.MaxValue;
        foreach (int val in values) { min = (min > val ? val : min); }
        return min;
    }
}