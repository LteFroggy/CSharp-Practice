using System;
using ZooSimulator;

Animal[] animals = new Animal[] {
    new Lion("시바", 5),
    new Elephant("덤보", 10),
    new Penguin("뽀로로", 3)
};

Console.WriteLine($"[동물 정보]");
foreach (Animal a in animals) {
    a.DisplayInfo();
}
Console.WriteLine();


Console.WriteLine($"[동물 소리]");
foreach (Animal a in animals) {
    a.MakeSound();
}
Console.WriteLine();


Console.WriteLine($"[동물 행동]");
foreach (Animal a in animals) {
    a.Eat();
    if (a is Lion lion) {
        lion.Hunt();
    } else if (a is Penguin penguin) {
        penguin.Swim();
    } else if (a is Elephant elephant) {
        elephant.SprayWater();
    }
}
Console.WriteLine();
Console.WriteLine();
