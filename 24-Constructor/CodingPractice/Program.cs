using System;
using System.Linq.Expressions;

// 1. 생성자 만들기
{
    Person p1 = new Person();
    Console.WriteLine(p1.GetName);
    Console.WriteLine();
    Console.WriteLine();
}

// 2. 기본 생성자.
{
    Dog d1 = new Dog();
    d1.Name = "해피";
    Console.WriteLine($"{d1.Name}");
    Console.WriteLine();
    Console.WriteLine();
}

// 3. 매개변수가 있는 생성자.
{
    Dog d1 = new Dog("해피");
    Dog d2 = new Dog("워리");
    d1.Cry();
    d2.Cry();
    Console.WriteLine();
    Console.WriteLine();
}

// 4. this 키워드로 필드와 매개변수 구분
{
    Person p1 = new Person("홍길동", 21);
    p1.PrintInfo();
    Console.WriteLine();
    Console.WriteLine();
}

// 5. 원의 면적 계산
{
    Circle c1 = new Circle(10);
    Circle c2 = new Circle(5);
    Console.WriteLine($"반지름 10인 원의 면적 : {c1.GetArea():F2}");
    Console.WriteLine($"반지름 5인 원의 면적 : {c2.GetArea():F2}");
    Console.WriteLine();
    Console.WriteLine();
}

// 6. 생성자 오버로딩
{
    ConstructorLog cl1 = new ConstructorLog();
    ConstructorLog cl2 = new ConstructorLog("C#");
    ConstructorLog cl3 = new ConstructorLog("Unity");
    Console.WriteLine();
    Console.WriteLine();
}

// 7. 생성자 오버로딩 활용
{
    Person2 p1 = new Person2();
    Person2 p2 = new Person2("백두산");
    Person2 p3 = new Person2("임꺽정", 30);
    Console.WriteLine();
    Console.WriteLine();
}

// 8. this() 생성자로 다른 생성자 호출
{
    Say s1 = new Say("[2] 잘가요.");
    Console.WriteLine();
    Console.WriteLine();
}

// 9. 생성자 전달
{
    Money m1 = new Money();
    Money m2 = new Money(2000);
    Console.WriteLine();
    Console.WriteLine();
}

// 10. 정적 생성자와 인스턴스 생성자
{
    Person3.ShowName();
    Person3 p1 = new Person3(21);
    Person3 p2 = new Person3(30);
    Console.WriteLine();
    Console.WriteLine();
}

// 11. 읽기 전용 필드와 생성자
{
    WhichService ws1 = new WhichService("파일 로그");
    WhichService ws2 = new WhichService("DB 로그");
    Console.WriteLine();
    Console.WriteLine();
}

// 12. 식 본문 생성자
{
    Pet p1 = new Pet("야옹이");
    Console.WriteLine(p1.name);
}