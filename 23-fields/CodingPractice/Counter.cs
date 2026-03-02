using System;
using System.Reflection.Emit;

class Counter {
    public static int count;

    public Counter() {
        count++;
    }

    public void ShowCounter() {
        Console.WriteLine($"현재 카운트 : {count}");
    }
}