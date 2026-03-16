using CodingPractice.Q1;
using CodingPractice.Q2;
using Q3;
using Q6_3;
using System;

// 1-1. 기본 사용법
{
    Parent parent = new Parent();
    parent.Work();
    parent = new Child();
    parent.Work();
    Console.WriteLine();
    Console.WriteLine();
}

// 1-2. 다형성과 오버라이드
{
    Animal animal = new Animal();
    animal.Eat();
    animal = new Cat();
    animal.Eat();
    Console.WriteLine();
    Console.WriteLine();
}

// 2. new vs override 동작 비교
{
    Q2.Child child = new Q2.Child();
    child.Say();
    child.Run();
    child.Walk();

    Q2.Parent parent = child;
    parent.Say();
    parent.Run();
    parent.Walk();
    Console.WriteLine();
    Console.WriteLine();
}

// 3. 메서드 오버로드 vs 오버라이드
{
    Calculator calculator = new Calculator();
    Console.WriteLine(calculator.Add(1, 2));
    Console.WriteLine(calculator.Add(2.5, 1.5));
    Console.WriteLine(calculator.Add(1, 2, 3));
    Console.WriteLine();
    Console.WriteLine();
}


// 3-2. 오버라이드
{
    Q3_2.Animal animal = new Q3_2.Animal();
    animal.Speak();
    animal = new Q3_2.Dog();
    animal.Speak();
    animal = new Q3_2.Cat();
    animal.Speak();
    Console.WriteLine();
    Console.WriteLine();
}

// 4-1. base키워드 기본
{
    Q4_1.Parent parent = new Q4_1.Child();
    parent.Greet();
    Console.WriteLine();
    Console.WriteLine();
}

// 4-2. Base 키워드 활용
{
    Q4_2.Parent parent = new Q4_2.Parent();
    Q4_2.Child child = new Q4_2.Child();
    Q4_2.GrandChild grandChild = new Q4_2.GrandChild();
    parent.Work();
    child.Work();
    grandChild.Work();
    Console.WriteLine();
    Console.WriteLine();
}

// 5. 메서드 오버라이드 봉인 (sealed)
{
    Q5.Parent parent = new Q5.Parent();
    Q5.Child child = new Q5.Child();
    Q5.GrandChild grandChild = new Q5.GrandChild();

    parent.Work();
    child.Work();
    grandChild.Work();
    grandChild.Play();
    Console.WriteLine();
    Console.WriteLine();
}

// 6-1. 기본 동작 확인
{
    Q6_1.Person person = new Q6_1.Person();
    Console.WriteLine(person);
    Console.WriteLine(person.ToString());
    Console.WriteLine();
    Console.WriteLine();
}

// 6-2. ToString() 오버라이드
{
    Q6_2.Person person = new Q6_2.Person("박용준");
    Console.WriteLine(person);
    Console.WriteLine(person.ToString());
    Console.WriteLine();
    Console.WriteLine();
}

// 6-3. 게임 캐릭터 예제
{
    Q6_3.Character character = new Q6_3.Character("용사", 10, 100);
    Q6_3.Character character2 = new Q6_3.Character("마법사", 8, 70);
    Console.WriteLine(character);
    Console.WriteLine(character2);
    Console.WriteLine();
    Console.WriteLine();
}

// 7-1 Rpg System
{
    Q7_1.Character warrior = new Q7_1.Warrior("전사", 50);
    Q7_1.Character mage = new Q7_1.Mage("마법사", 40);
    Q7_1.Character archer = new Q7_1.Archer("궁수", 60);

    warrior.PrintInfo();
    mage.PrintInfo();
    archer.PrintInfo();
    Console.WriteLine();

    warrior.Attack();
    mage.Attack();
    archer.Attack();
    Console.WriteLine();
    Console.WriteLine();
}

// 7-2. 다형성 활용
{
    Q7_1.Character[] characters = new Q7_1.Character[] {
        new Q7_1.Warrior("전사", 50),
        new Q7_1.Mage("마법사", 40),
        new Q7_1.Archer("궁수", 60)
    };

    Console.WriteLine($"=== 파티 공격 ===");
    foreach (Q7_1.Character character in characters) {
        character.Attack();
    }
    Console.WriteLine();
    Console.WriteLine();
}