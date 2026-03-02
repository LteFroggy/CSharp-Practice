using System;

class Player3 {
    private string _name;

    public static int totalCount;

    public Player3(string name) {
        _name = name;
        Console.WriteLine(_name);
        totalCount++;
    }
}