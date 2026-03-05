using System;


// 1. 간단한 클래스와 객체
{
    Dog myDog = new Dog("초코", 3);
    myDog.Bark();
    myDog.PrintInfo();
    Console.WriteLine();
    Console.WriteLine();
}

// 2. var 키워드로 객체 생성
{
    Monster m1 = new Monster();
    var m2 = new Monster();
    Console.WriteLine(m1);
    Console.WriteLine(m2);
    Console.WriteLine();
    Console.WriteLine();
}


// 3. 인스턴스 메서드
{
    Calculator calculator = new Calculator();
    Console.WriteLine(calculator.Add(3, 5));
    Console.WriteLine(calculator.Multiply(3, 5));
    Console.WriteLine();
    Console.WriteLine();
}

// 4. 인스턴스 메서드와 필드
{
    Counter counter = new Counter();
    counter.Increment();
    counter.Increment();
    counter.Increment();
    counter.Reset();
    Console.WriteLine();
    Console.WriteLine();
}

// 5. 정적 멤버와 인스턴스 멤버
{
    GameManager gameManager = new GameManager();
    GameManager.ShowStatus();
    gameManager.Greet();
    Console.WriteLine();
    Console.WriteLine();
}

// 6. 여러 클래스 함께 사용
{
    Greeting greeting= new Greeting();
    Farewell farewell= new Farewell();
    Greeting.SayHello();
    Farewell.Wave();
    greeting.SayGoodbye();
    farewell.Bow();
    Console.WriteLine();
    Console.WriteLine();
}

// 7. ToString() 기본 동작
{
    Item item = new Item("포션", 100);
    Console.WriteLine(item);
    Console.WriteLine();
    Console.WriteLine();
}

// 8. ToString() 오버라이드
{
    Item2 item2 = new Item2("포션", 100);
    Console.WriteLine(item2);
    Console.WriteLine();
    Console.WriteLine();
}

// 9. ToString() 활용
{
    Player p1 = new Player("전사", 10, 200);
    Player p2 = new Player("마법사", 8, 120);
    Console.WriteLine();
    Console.WriteLine();
}

// 10. 클래스 배열
{
    Enemy[] enemyArr = new Enemy[3];
    enemyArr[0] = new Enemy("고블린", 50);
    enemyArr[1] = new Enemy("오크", 100);
    enemyArr[2] = new Enemy("드래곤", 500);

    for (int i = 0; i < enemyArr.Length; i++) {
        enemyArr[i].ShowInfo();
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 11. foreach로 클래스 배열 순회
{
    UserItem[] userItems = new UserItem[3];
    userItems[0] = new UserItem("검", 500);
    userItems[1] = new UserItem("방패", 300);
    userItems[2] = new UserItem("포션", 50);

    foreach (UserItem item in userItems) {
        Console.WriteLine(item);
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 12. 개체 이니셜라이저
{
    Character ch1 = new Character {
        _name = "홍길동",
        _level = 1,
        _job = "전사"
    };

    Character ch2 = new Character {
        _name = "이순신",
        _level = 5,
        _job = "궁수"
    };
    
    ch1.PrintInfo();
    ch2.PrintInfo();
    Console.WriteLine();
    Console.WriteLine();
}

// 13. 배열에서 개체 이니셜라이저 활용
{
    Character ch1 = new Character();
    ch1._name = "홍길동";
    ch1._level = 1;
    ch1._job = "전사";

    Character ch2 = new Character {
        _name = "이순신",
        _level = 5,
        _job = "궁수"
    };

    ch1.PrintInfo();
    ch2.PrintInfo();
    Console.WriteLine();
    Console.WriteLine();
}