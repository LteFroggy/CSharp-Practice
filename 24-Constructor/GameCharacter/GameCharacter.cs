using System;

class GameCharacter {
    private const int k_DefaultHealth = 100;
    private const int k_DefaultAttack = 10;

    private static int _nextId;

    private readonly int _id;

    private string _name;
    private int _health;
    private int _attack;

    static GameCharacter() {
        _nextId = 1;
        Console.WriteLine($"[시스템] GameCharacter 클래스 로드됨");
    }

    public GameCharacter() : this("무명의 영웅", k_DefaultHealth, k_DefaultAttack) { }
    public GameCharacter(string name) : this(name, k_DefaultHealth, k_DefaultAttack) { }

    public GameCharacter(string name, int health, int attack) {
        _name = name;
        _health = health;
        _attack = attack;
        _id = _nextId++;
        Console.WriteLine($"[ID : {_id}] 캐릭터 '{_name}' 생성됨");
    }

    public void PrintStatus() {
        Console.WriteLine($"=== 캐릭터 #{_id} : {_name} ===");
        Console.WriteLine($"  체력 : {_health, 3} / 공격력 : {_attack, 2}");
    }
}