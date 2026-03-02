using System;
class Player2 {
    private string _name = "이름없음";
    private int _health = 100;
    private int _level = 1;

    public void ShowStatus() {
        Console.WriteLine($"이름 : {_name}");
        Console.WriteLine($"체력 : {_health}");
        Console.WriteLine($"레벨 : {_level}");
    }
}