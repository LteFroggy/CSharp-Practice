using System;

class Counter {
    private static int _totalCount;
    private int _instanceNumber;

    static Counter() {
        _totalCount = 0;
    }

    public Counter () {
        _instanceNumber = ++_totalCount;
        Console.WriteLine($"개체 {_instanceNumber} 생성됨");
    }

    public static int GetTotalCount() => _totalCount;
    public int GetInstanceNumber() => _instanceNumber;
}