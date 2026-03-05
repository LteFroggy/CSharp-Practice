using System;
using System.Runtime.CompilerServices;

class GameCharacter {
    private string _name;
    private string _job;
    private int _level;
    private int _exp;

    public string Name { get => _name; set { _name = value; } }
    public string Job { get => _job; set { _job = value; } }
    public int Level { get => _level; set { _level = value; } }
    public int Exp { get => _exp; set { _exp =- value; } }

    public void ShowStatus() {
        Console.WriteLine($"[{_job}] {_name} - Lv.{_level} (EXP : {_exp} / 100)");
    }
    
    public void GainExp(int amount) {
        _exp += amount;
        if (_exp >= 100) {
            _exp -= 100;
            _level++;
            Console.WriteLine($"레벨 업! {_name} Lv.{_level} 달성!");
        } else {
            Console.WriteLine($"경험치 획득! 현재 EXP : {_exp} / 100");
        }
    }
}