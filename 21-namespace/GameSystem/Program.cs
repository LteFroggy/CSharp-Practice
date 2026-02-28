using System;
using MyGame.Characters;
using MyGame.Items;

Player p1 = new Player("용사");
Enemy e1 = new Enemy("고블린");
Weapon w1 = new Weapon("불꽃검", 50);
Potion potion = new Potion("체력 포션");

Console.WriteLine($"=== 캐릭터 시스템 ===");
p1.Attack();
e1.TakeDamage();
Console.WriteLine();

Console.WriteLine($"=== 아이템 시스템 ===");
w1.GetDamage();
potion.Use();
Console.WriteLine();
Console.WriteLine();