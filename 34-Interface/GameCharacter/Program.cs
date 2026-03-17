using GameCharacter;
using System;

Character character = new Character(new HealthComponent(Character.k_MaxHp), "용사");
Monster monster = new Monster(new HealthComponent(Monster.k_MaxHp), "슬라임", 5);

Console.WriteLine($"=== 전투 시작 ===");
Console.WriteLine();

character.Attack(monster);
monster.Attack(character);
character.Attack(monster);
Console.WriteLine();

Console.WriteLine($"=== 고블린 등장 ===");
monster = new Monster(new HealthComponent(50), "고블린", 10);
character.Attack(monster);
monster.Attack(character);
character.Attack(monster);
character.Attack(monster);