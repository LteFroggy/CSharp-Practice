using System;

class Character {
    public string _name;
    public int _level;
    public string _job;

    public void PrintInfo() {
        Console.WriteLine($"{_name} - {_job} Lv.{_level}");
    }
}