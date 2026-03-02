using System;
using CodingPractice;

// 과제 1. 클래스 선언과 멤버 호출
{
    ClassName.MemberName();
    Console.WriteLine();
    Console.WriteLine();
}


// 과제 2. 정적 멤버 호출
{
    Console.WriteLine(Square.GetName());
    Console.WriteLine();
    Console.WriteLine();
}

// 과제 3. 정적 메서드와 인스턴스 메서드
{
    MyFirstClass.StaticMethod();
    MyFirstClass myClass = new MyFirstClass();
    myClass.InstanceMethod();
    Console.WriteLine();
    Console.WriteLine();
}

//  과제 4. 개체 생성과 필드 사용
{
    Person a = new Person();
    Person b = new Person();
    a.Name = "홍길동";
    a.Age = 25;
    b.Name = "김철수";
    b.Age=  30;
    a.Introduce();
    b.Introduce();
    Console.WriteLine();
    Console.WriteLine();
}

// 5. 참조 타입 확인
{
    Point a = new Point();
    a.X = 10;
    Point b = a;
    b.X = 100;
    Console.WriteLine($"point1.X = {a.X}");
    Console.WriteLine($"point2.X = {b.X}");
    Console.WriteLine();
    Console.WriteLine();
}

// 과제 6. 클래스와 구조체 비교
{
    PointStruct sA = new PointStruct();
    sA.x = 10;
    PointStruct sB = sA;
    sB.x = 100;

    PointClass cA = new PointClass();
    cA.x = 10;
    PointClass cB = cA;
    cB.x = 100;

    Console.WriteLine($"구조체 : ps1.X = {sA.x}, ps2.X = {sB.x}");
    Console.WriteLine($"클래스 : pc1.X = {cA.x}, pc2.X = {cB.x}");
    Console.WriteLine();
    Console.WriteLine();
}

// 7. 메서드 정의
{
    Console.WriteLine($"3 + 5 = {Calculator.Add(3, 5)}");
    Console.WriteLine($"3 * 5 = {Calculator.Multiply(3, 5)}");
    Console.WriteLine();
    Console.WriteLine();
}

// 과제 8. 생성자 오버로딩
{
    Player p1 = new Player();
    Player p2 = new Player("용사", 150);
    p1.PrintInfo();
    p2.PrintInfo();
    Console.WriteLine();
    Console.WriteLine();
}

// 과제 9. 속성 (Property)
{
    Stock myStock = new Stock();
    myStock.CurrentPrice = 30;
    Console.WriteLine($"주가 : {myStock.CurrentPrice}");
    Console.WriteLine();
    Console.WriteLine();
}

// 10. 자동 구현 속성
{
    Product myProduct = new Product();
    myProduct.Name = "노트북";
    myProduct.Price = 15000000;
    Console.WriteLine($"{myProduct.Name} : {myProduct.Total} (수량 : {myProduct.Quantity}");
    Console.WriteLine();
    Console.WriteLine();
}

// 11. 읽기 전용 속성
{
    Circle myCircle = new Circle();
    myCircle.Radius = 5;
    Console.WriteLine($"반지름 : {myCircle.Radius}, 넓이 : {myCircle.Area:F2}");
    Console.WriteLine();
    Console.WriteLine();
}

// 12. new 키워드와 객체 생성
{
    Monster goblin = new Monster();
    goblin.Name = "고블린";
    goblin.Health = 50;

    Monster oak = new Monster {
        Name = "오크",
        Health = 200
    };

    goblin.Attack();
    oak.Attack();   
    Console.WriteLine();
    Console.WriteLine();
}

// 13. 개체 이니셜라이저
{
    Character myCharacter = new Character {
        Name = "용사",
        Level = 10,
        Job = "전사"
    };

    myCharacter.PrintInfo();
    Console.WriteLine();
    Console.WriteLine();
}

// 14. Random 클래스 기본 사용
{
    Random rand = new Random();

    Console.WriteLine($"임의의 정수 : {rand.Next()}");
    Console.WriteLine($"0 ~ 4: {rand.Next(5)}");
    Console.WriteLine($"1 ~ 9: {rand.Next(1, 10)}");
    Console.WriteLine($"0.0 ~ 1.0: {rand.NextDouble():F4}");
    Console.WriteLine();
    Console.WriteLine();
}

// 15. 주사위 프로그램
{
    Random rand = new Random();
    int diceCount = 5;

    Console.WriteLine($"주사위를 {diceCount}번 굴립니다.");
    for (int i = 0; i < diceCount; i++) {
        Console.WriteLine($"{i + 1}번째 : {rand.Next(1, 7)}");
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 16. this키워드
{
    Person2 alice = new Person2("Alice", 15);
    Person2 bob = new Person2("Bob", 15);
    alice.SetFriend(bob);
}
