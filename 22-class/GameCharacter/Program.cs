using System;

GameCharacter.GameCharacter hero = new GameCharacter.GameCharacter("용사", 5);
GameCharacter.GameCharacter monster = new GameCharacter.GameCharacter("고블린", 3);

hero.ShowStatus();
monster.ShowStatus();

Console.WriteLine("\n=== 전투 시작 ===");

hero.Attack(monster);
monster.ShowStatus();

hero.Attack(monster);
monster.ShowStatus();

hero.Attack(monster);
monster.ShowStatus();

hero.Attack(monster);
monster.ShowStatus();