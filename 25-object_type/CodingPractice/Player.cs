using System;

class Player {
    private string _name;
    private int _level;
    private int _health;

    public Player(string name, int level, int health) {
        _name = name;
        _level = level;
        _health = health;
    }

    public override string ToString() {
        return $"[{_level}레벨] {_name} (HP : {_health})";
    }
}