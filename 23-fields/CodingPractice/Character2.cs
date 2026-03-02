using System;

class Character2 {
    private string _name;
    private int _level;

    public void SetInfo(string name, int level) {
        _name = name;
        _level = level;
    }

    public void ShowStatus() {
        Console.WriteLine($"이름 : {_name}");
        Console.WriteLine($"레벨 : {_level}");
    }
}