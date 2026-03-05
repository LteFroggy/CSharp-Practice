using System;

class Enemy {
    private string _name;
    private int _health;
    
    public Enemy(string name, int health) {
        _name = name;
        _health = health;
    }

    public void ShowInfo() {
        Console.WriteLine($"{_name} : HP {_health}");
    }
}