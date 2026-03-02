using System;

// 과제 1. 필드가 있는 클래스 만들기
{
    Player p1 = new Player();
    p1.ShowStatus();
    Console.WriteLine();
    Console.WriteLine();
}

// 과제 2. Public 필드
{
    Character c1 = new Character();
    c1.name = "용사";
    c1.level = 10;

    Console.WriteLine($"{c1.name}");
    Console.WriteLine($"{c1.level}");
    Console.WriteLine();
    Console.WriteLine();
}

// 과제 3. private 필드
{
    Character2 c1 = new Character2();
    c1.SetInfo("용사", 10);
    c1.ShowStatus();
    Console.WriteLine();
    Console.WriteLine();
}

// 과제 4. 선언과 동시에 초기화
{
    Player2 p1 = new Player2();
    p1.ShowStatus();
    Console.WriteLine();
    Console.WriteLine();
}

// 과제 5. 필드 이니셜라이저
{
    Say s1 = new Say();
    s1.Hi();
    Console.WriteLine();
    Console.WriteLine();
}

// 과제 6. 배열 필드 초기화
{
    Schedule sc = new Schedule();
    sc.PrintWeekDays();
    Console.WriteLine();
    Console.WriteLine();
}

// 7. 기본값 확인
{
    DefaultValues dv = new DefaultValues();
    dv.ShowDefaults();
    Console.WriteLine();
    Console.WriteLine();
}

// 8. 정적 필드 선언과 사용
{
    Counter c1 = new Counter();
    c1.ShowCounter();
    Counter c2 = new Counter();
    c2.ShowCounter();
    Counter c3 = new Counter();
    c3.ShowCounter();
    Console.WriteLine();
    Console.WriteLine();
}

// 인스턴스 필드 vs 정적 필드
{
    Player3 p1 = new Player3("용사");
    Player3 p2 = new Player3("궁수");
    Player3 p3 = new Player3("마법사");
    Console.WriteLine(Player3.totalCount);
    Console.WriteLine();
    Console.WriteLine();
}

// 10. readonly 필드
{
    GameConfig gc = new GameConfig();
    gc.ShowStatus();
    Console.WriteLine();
    Console.WriteLine();
}

// 11. readonly vs const 비교
{
    Example ex = new Example();
    ex.ShowValues();
    Console.WriteLine();
    Console.WriteLine();
}

// 12. this 키워드
{
    Player4 p1 = new Player4();
    p1.SetInfo("용사", 10);
    Console.WriteLine();
    Console.WriteLine();
}

// 13. 다양한 필드 타입 활용
{
    Person p1 = new Person();
    p1.ShowProfile();
    Console.WriteLine();
    Console.WriteLine();
}

// 14. 게임 캐릭터 클래스
{
    GameCharacter gc1 = new GameCharacter("용사", 15);
    Console.WriteLine();
    GameCharacter gc2 = new GameCharacter("마법사", 25);
    Console.WriteLine();
    gc1.GetDamage(30);
    gc1.GetDamage(50);
    gc1.GetDamage(50);
    Console.WriteLine();

    GameCharacter.PrintStatus();
    Console.WriteLine();
    Console.WriteLine();
}