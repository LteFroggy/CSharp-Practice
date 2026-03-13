using System;
using System.Security.Cryptography.X509Certificates;
using CodingPractice.Q1_2;
using CodingPractice.Q12;
using CodingPractice.Q2;
using CodingPractice.Q3;
using CodingPractice.Q4;
using CodingPractice.Q5_1;
using CodingPractice.Q7;
using CodingPractice.Q8_1;
using CodingPractice.Q8_2;
using CodingPractice.Q9;

// 1-1. 기본 상속 문법
{
    Child child = new Child();
    child.Greet();
    child.Study();
    Console.WriteLine();
    Console.WriteLine();
}

// 1-2. 동물 클래스 상속
{
    Dog dog = new Dog();
    dog.Name = "초코";
    Cat cat = new Cat();
    cat.Name = "나비";

    dog.Eat();
    dog.Bark();
    cat.Eat();
    cat.Meow();
    Console.WriteLine();
    Console.WriteLine();
}

// 2. Object 클래스
{
    Product product = new Product();
    Console.WriteLine(product.ToString());
    Console.WriteLine(product.GetType());
    Console.WriteLine();
    Console.WriteLine();
}

// 3. 접근 제한자와 상속
{
    CodingPractice.Q3.Child child = new CodingPractice.Q3.Child();
    child.ShowValues();
    Console.WriteLine();
    Console.WriteLine();
}

// 4. Base 키워드
{
    Manager manager = new Manager();
    manager.ShowInfo();
    Console.WriteLine();
    Console.WriteLine();
}

// 5-1. 부모 생성자 호출
{
    Student student = new Student("홍길동", 3);
    student.ShowInfo();
    Console.WriteLine();
    Console.WriteLine();
}

// 5-2. 암시적 기본 생성자 호출
{
    CodingPractice.Q5_2.Dog dog = new CodingPractice.Q5_2.Dog();   
    Console.WriteLine();
    Console.WriteLine();
}

// 6-1. 업캐스팅
{
    CodingPractice.Q6_1.Animal animal = new CodingPractice.Q6_1.Dog();
    animal.Name = "멍멍이";
    animal.Eat();
    Console.WriteLine();
    Console.WriteLine();
}

// 6-2. 다운캐스팅
{
    CodingPractice.Q6_1.Animal animal = new CodingPractice.Q6_1.Dog();
    animal.Name = "멍멍이";
    CodingPractice.Q6_1.Dog dog = (CodingPractice.Q6_1.Dog)animal;
    dog.Bark();
    Console.WriteLine();
    Console.WriteLine();
}

// 6-3. is 연산자로 타입 검사
{
    CodingPractice.Q6_1.Animal animal = new CodingPractice.Q6_1.Dog();
    animal.Name = "멍멍이";
    if (animal is CodingPractice.Q6_1.Dog) {
        CodingPractice.Q6_1.Dog dog = (CodingPractice.Q6_1.Dog)animal;
        dog.Bark();
    } 
    Console.WriteLine();   
    Console.WriteLine();   
}

// 6-4. is 패턴 매칭
{
    CodingPractice.Q6_1.Animal animal = new CodingPractice.Q6_1.Dog();
    animal.Name = "멍멍이";
    if (animal is CodingPractice.Q6_1.Dog dog) {
        dog.Bark();
    }
    Console.WriteLine();   
    Console.WriteLine();   
}

// 6-5. as 연산자로 안전한 캐스팅
{
    CodingPractice.Q6_1.Animal animal = new CodingPractice.Q6_1.Cat();
    CodingPractice.Q6_1.Dog dog = animal as CodingPractice.Q6_1.Dog;
    if (dog == null) {
        Console.WriteLine($"dog 타입이 아닙니다.");
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 7. 다형성
{
    Asset[] assets = new Asset[] {
        new Stock("삼성전자"),
        new House("아파트"),
        new Stock("SK 하이닉스")
    };

    foreach ( Asset asset in assets ) {
        Console.WriteLine($"{asset.Name}");
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 8-1 추상 클래스 기본.
{
    Shape rect = new Rectangle(5, 10);
    Shape circle = new Circle(4);
    Console.WriteLine(rect.GetArea());
    Console.WriteLine($"{circle.GetArea():F2}");
    Console.WriteLine();
    Console.WriteLine();
}

// 8-2. 추상 메서드
{
    Vehicle vehicle = new Car();
    vehicle.Start();
    vehicle.Stop();
    Console.WriteLine();
    Console.WriteLine();
}

// 9. 봉인 클래스
{
    FinalClass fc = new FinalClass();
    fc.Display();
    Console.WriteLine();
    Console.WriteLine();
}

// 10. 멤버 숨기기
{
    CodingPractice.Q10.Parent parent = new CodingPractice.Q10.Parent();
    CodingPractice.Q10.Child child = new CodingPractice.Q10.Child();

    Console.WriteLine($"child.Value = {child.Value}");
    Console.WriteLine($"parent.Value = {parent.Value}");
    parent.Show();
    child.Show();
    Console.WriteLine();
    Console.WriteLine();
}

// 11. is - a 관계
{
    CodingPractice.Q11.Animal animal = new CodingPractice.Q11.Animal();
    CodingPractice.Q11.Dog dog = new CodingPractice.Q11.Dog();
    CodingPractice.Q11.Cat cat = new CodingPractice.Q11.Cat();
    Console.WriteLine($"{dog is CodingPractice.Q11.Animal}");
    Console.WriteLine($"{cat is CodingPractice.Q11.Animal}");
    Console.WriteLine($"{animal is CodingPractice.Q11.Cat}");
    Console.WriteLine();
    Console.WriteLine();
}

// 12. 게임 캐릭터 시스템
{
    GameCharacter c1 = new Warrior("아서", 150, 25);
    GameCharacter c2 = new Mage("멀린", 80, 40);
    GameCharacter c3 = new Warrior("란슬롯", 150, 30);

    c1.ShowStatus();
    c1.Attack();
    Console.WriteLine();
    c2.ShowStatus();
    c2.Attack();
    Console.WriteLine();
    c3.ShowStatus();
    c3.Attack();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
}