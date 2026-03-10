using System;
using System.Runtime.CompilerServices;

// 1. public 필드의 문제점
{
    A1.Player p1 = new A1.Player();
    p1.Health = 100;
    Console.WriteLine($"플레이어의 체력은 {p1.Health}입니다.");
    p1.Health = -999;
    Console.WriteLine($"플레이어의 체력은 {p1.Health}입니다.");
    Console.WriteLine();
    Console.WriteLine();
}

// 2. Get,Set 메서드 방식
{
    A2.Player p1 = new A2.Player();
    p1.SetHealth(100);
    Console.WriteLine(p1.GetHealth());
    Console.WriteLine();
    Console.WriteLine();
}

// 3. 전체 프로퍼티
{
    A3.Person p1 = new A3.Person();
    p1.Name = "홍길동";
    Console.WriteLine($"p1.Name");
    Console.WriteLine();
    Console.WriteLine();
}

// 4. 자동 구현 프로퍼티
{
    A4.Developer d1 = new A4.Developer();
    d1.Name = "김개발";
    d1.Age = 25;
    Console.WriteLine($"{d1.Name}, {d1.Age}세");
    Console.WriteLine();
    Console.WriteLine();
}

// 5. 자동 프로퍼티 이니셜라이저
{
    A5.Player p1 = new A5.Player();
    Console.WriteLine($"이름 : {p1.Name}");
    Console.WriteLine($"레벨 : {p1.Level}");
    Console.WriteLine($"최대 체력 : {p1.MaxHealth}");
    Console.WriteLine();
    Console.WriteLine();
}

// 6. 전체 프로퍼티 vs 자동 프로퍼티
{
    A6.Car c1 = new A6.Car();
    c1.Name = "소나타";
    c1.Color = "검정";
    Console.WriteLine($"{c1.Name}, {c1.Color}");
    Console.WriteLine();
    Console.WriteLine();
}

// 7. 읽기 전용 프로퍼티
{
    A7.Product p1 = new A7.Product();
    Console.WriteLine(p1.Manufactruer);
    Console.WriteLine();
    Console.WriteLine();
}

// 8. private set을 사용한 읽기 전용
{
    A8.Page p1 = new A8.Page();
    Console.WriteLine(p1.Message);
    p1.UpdateMessage("업데이트한 메세지");
    Console.WriteLine(p1.Message);
    Console.WriteLine();
    Console.WriteLine();
}

// 9. 쓰기 전용 프로퍼티
{
    A9.SecureData sd = new A9.SecureData("12345");
    Console.WriteLine(sd.Validate("12345"));
    Console.WriteLine();
    Console.WriteLine();
}

// 10. 읽기 전용 식 본문 프로퍼티
{
    A10.Circle circle = new A10.Circle();
    circle.Radius = 5;
    Console.WriteLine($"반지름 : {circle.Radius}");
    Console.WriteLine($"넓이 : {circle.Area}");
    Console.WriteLine($"둘레 : {circle.Circumference}");
    Console.WriteLine();
    Console.WriteLine();
}

// 11. get/set 식 본문
{
    A11.Counter counter = new A11.Counter();
    counter.Count = 10;
    counter.Increase();
    Console.WriteLine($"카운트 : {counter.Count}");
    Console.WriteLine();
    Console.WriteLine();
}

// 12. 프로퍼티에서 유효성 검사
{
    A12.Player player = new A12.Player();
    player.Health = 150;
    Console.WriteLine(player.Health);
    player.Health = -50;
    Console.WriteLine(player.Health);
    Console.WriteLine();
    Console.WriteLine();
}

// 13. 계산된 프로퍼티
{
    A13.Player p1 = new A13.Player();
    p1.BirthYear = 2000;
    Console.WriteLine($"홍길동님의 나이 : {p1.Age}");
    Console.WriteLine();
    Console.WriteLine();
}

// 14. 개체 이니셜라이저 (기존 방식) 
{
    A14.Course course = new A14.Course();
    course.Id = 1;
    course.Title = "C# 기초";
    Console.WriteLine($"{course.Id} - {course.Title}");
    Console.WriteLine();
    Console.WriteLine();
}

// 15. 개체 이니셜라이저 사용
{
    A14.Course course = new A14.Course() {
        Id = 1, 
        Title = "C# 기초"
    };
    Console.WriteLine($"{course.Id} - {course.Title}");
    Console.WriteLine();
    Console.WriteLine();
}

// 16. 데이터 클래스
{
    A16.Customer customer = new A16.Customer() {
        Id = 1,
        Name = "김철수",
        Email = "kim@example.com",
        City = "서울"
    };
    Console.WriteLine($"고객 #{customer.Id}");
    Console.WriteLine($"이름 : {customer.Name}");
    Console.WriteLine($"이메일 : {customer.Email}");
    Console.WriteLine($"도시 : {customer.City}");
    Console.WriteLine();
    Console.WriteLine();
}

// 17. 정적 프로퍼티
{
    A17.GameSettings gameSettings= new A17.GameSettings();
    Console.WriteLine($"게임 : {gameSettings.GameTitle}");
    Console.WriteLine($"최대 플레이어 : {gameSettings.MaxPlayers}");
    Console.WriteLine($"사운드 : {gameSettings.IsSoundEnabled}");
    gameSettings.MaxPlayers = 8;
    Console.WriteLine($"변경된 최대 플레이어 : {gameSettings.MaxPlayers}");
    Console.WriteLine();
    Console.WriteLine();
}

// 18. 프로퍼티 종합 예제
{
    int damageAmount = 50;

    A18.Monster monster = new A18.Monster("고블린");
    monster.Level = 5;
    monster.Attack = 15;
    Console.WriteLine($"이름 : {monster.Name}");
    Console.WriteLine($"레벨 : {monster.Level}");
    Console.WriteLine($"체력 : {monster.Health}");
    Console.WriteLine($"공격력 : {monster.Attack}");
    Console.WriteLine($"방어력 : {monster.Defense}");
    Console.WriteLine($"생존 : {monster.IsAlive}");
    monster.TakeDamage(damageAmount);
    Console.WriteLine($"{damageAmount} 데미지 후 체력 : {monster.Health}");
    Console.WriteLine();
    Console.WriteLine();
}
