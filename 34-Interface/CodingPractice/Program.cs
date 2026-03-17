using Q1_1;
using Q1_2;
using Q1_3;
using Q3_2;
using Q4_1;
using Q4_2;
using Q5;
using Q6;
using Q7_1;
using Q7_2;
using System;
using System.Security.Cryptography.X509Certificates;

// 1-1. 기본 구현
{
    Q1_1.Car car = new Q1_1.Car();
    car.Go();
    Console.WriteLine();
    Console.WriteLine();
}

// 1-2. 인터페이스 형식의 변수
{
    Repository repository = new Repository();
    repository.Get();
    Console.WriteLine();
    Console.WriteLine();
}

// 1-3. 구현 클래스의 규칙
{
    Person person = new Person();
    person.Work();
    person.Rest();
    Console.WriteLine();
    Console.WriteLine();
}

// 2. 생성자 매개변수에 인터페이스 사용
{
    Q2.Car car = new Q2.Car(new Q2.NormalBattery());
    Q2.Car car2 = new Q2.Car(new Q2.GoodBattery());
    car.Run();
    car2.Run();
    Console.WriteLine();
    Console.WriteLine();
}

// 3-1. 여러 인터페이스 구현하기
{
    Q3_1.Dog dog = new Q3_1.Dog();
    dog.Eat();
    dog.Bark();
    Console.WriteLine();
    Console.WriteLine();
}

// 3-2. 클래스 상속과 인터페이스 구현 함께 사용
{
    Bird bird = new Bird();
    bird.Breathe();
    bird.Fly();
    Console.WriteLine();
    Console.WriteLine();
}

// 4-1. 이름 충돌 해결
{
    Pet pet = new Pet();
    ((IDog)pet).Eat();
    ((ICat)pet).Eat();
    ((IDog)pet).Eat();
    ((ICat)pet).Eat();
    Console.WriteLine();
    Console.WriteLine();
}

// 4-2. 명시적 구현의 특징
{
    Example example = new Example();
    ((IExample)example).DoWork();
    Console.WriteLine();
    Console.WriteLine();
}

// 5. 인터페이스 상속
{
    TextEditor textEditor = new TextEditor();
    textEditor.Undo();
    textEditor.Redo();
    Console.WriteLine();
    Console.WriteLine();
}

// 6. 인터페이스와 추상 클래스 비교
{
    Q6.Car car = new Q6.Car();
    car.Run();
    car.Left();
    car.Back();
    Console.WriteLine();
    Console.WriteLine();
}

// 7-1. 데미지 시스템
{
    void Attack(IDamageable target, int damage) {
        target.TakeDamage(damage);
    }

    Player player = new Player(new DamageComponent(100));
    Enemy enemy = new Enemy(new DamageComponent(50));
    Building building = new Building(new DamageComponent(500));

    Attack(player, 20);
    Attack(enemy, 30);
    Attack(building, 100);
    Console.WriteLine();
    Console.WriteLine();
}

// 7-2. 다중 인터페이스로 기능 조합
{
    Hero hero = new Hero();
    Turret turret = new Turret();
    hero.Move();
    hero.Attack();
    turret.Attack();
    Console.WriteLine();
    Console.WriteLine();
}