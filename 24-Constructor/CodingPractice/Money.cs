using System;

class Money {
    private int _money;
    public Money() : this(1000) { }

    public Money(int money) {
        _money = money;
        PrintMoney();
    }

    private void PrintMoney() {
        Console.WriteLine($"Money : {_money:N0}");
    }
}