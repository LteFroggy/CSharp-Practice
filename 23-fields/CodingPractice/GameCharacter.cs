using System;

class GameCharacter {
    private const int MaxHealth = 100;
    private readonly string _name;
    private int _health;
    private int _attack;
    private static int _characterCount;

    public GameCharacter(string name, int attack) {
        _name = name;
        _attack = attack;
        _health = MaxHealth;
        _characterCount++;

        Console.WriteLine($"=== {_name} ===");
        Console.WriteLine($"체력 : {_health}/{MaxHealth}");
        Console.WriteLine($"공격력 : {_attack}");
    }

    public void GetDamage(int amount) {
        if (_health < amount) {
            _health = 0;
        } else {
            _health -= amount;
        }
        Console.WriteLine($"{_name}이(가) {amount}데미지를 받음! 남은 체력 : {_health}");
    }

    public static void PrintStatus() {
        Console.WriteLine($"총 캐릭터 수 : {_characterCount}");
    }
}