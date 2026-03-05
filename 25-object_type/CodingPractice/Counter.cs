using System;

class Counter {
    private int _count;
    public void Increment() => Console.WriteLine($"현재 카운트 : {++_count}");
    public void Reset() {
        Console.WriteLine($"카운트가 초기화되었습니다.");
        _count = 0;
    }
}