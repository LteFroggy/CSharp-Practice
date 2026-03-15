using CodingPractice.Q2;
using CodingPractice.Q7_2;
using CodingPractice.Q9_2;
using CodingPractice.Q9_3;
using System;
using System.Drawing;
using System.Numerics;

// 1. Object 타입의 기본 개념
{
    object a = 42;
    object b = 3.14;
    object c = "Hello";
    object d = true;

    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(d);
    Console.WriteLine();
    Console.WriteLine();
}

// 2. Object 타입의 활용
{
    Stack stk = new Stack();
    object o1 = "sausage";
    object o2 = 3;
    stk.Push(o1); 
    stk.Push(o2);
    Console.WriteLine(stk.Pop());
    Console.WriteLine(stk.Pop());
    Console.WriteLine();
    Console.WriteLine();
}

// 3. 박싱과 언박싱
{
    int i = 1234;
    object o = i;
    Console.WriteLine(o);
    Console.WriteLine();
    Console.WriteLine();
}

// 3-2. 언박싱
{
    object o = 1234;
    int i = (int)o;
    Console.WriteLine(o);
    Console.WriteLine(i);
    Console.WriteLine();
    Console.WriteLine();
}

// 4-1. 값 타입을 Object에 할당
{
    int i = 42;
    object o = i;
    Console.WriteLine(o);
    Console.WriteLine();
    Console.WriteLine();
}

// 4-2. 값 타입을 인터페이스 타입에 할당
{
    Point a = new Point();
    Console.WriteLine($"{a.GetType().Name}");
    Console.WriteLine();
    Console.WriteLine();
}

// 5. 박싱의 특징
{
    int i = 3;
    object o = i;
    i = 5;
    Console.WriteLine($"원본 : {i}");
    Console.WriteLine($"박싱된 값 : {o}");
    Console.WriteLine();
    Console.WriteLine();
}

// 6. 언박싱 시 주의사항
{
    object o = 42;
    int i = (int)o;
    Console.WriteLine($"언박싱 성공 : {i}");
    try {
        string ab = (string)o;
    } catch {
        Console.WriteLine($"잘못된 타입으로 언박싱 시도");
    }
    Console.WriteLine($"올바른 변환 : {i}");
    Console.WriteLine();
    Console.WriteLine();
}

// 7-1. 박싱/언박싱 오버헤드 비교
{
    int sum1 = 0, sum2 = 0;
    for (int i = 0; i < 1000; i++) {
        object o = i;
        sum1 += (int)o;
        sum2 += i;
    }

    Console.WriteLine($"박싱 사용 : {sum1}");
    Console.WriteLine($"직접 처리 : {sum2}");
    Console.WriteLine();
    Console.WriteLine();
}

// 7-2. 제네릭으로 박싱 피하기
{
    GenericStack<int> gs = new GenericStack<int>();

    gs.Push(42);
    Console.WriteLine($"{gs.Pop()}");
    Console.WriteLine();
    Console.WriteLine();
}

// 8-1. GetType() 메서드
{
    int a = 10;
    string b = "hi";
    char c = 'a';
    double d = 3;
    object e = 3;
    Console.WriteLine(a.GetType());
    Console.WriteLine(b.GetType());
    Console.WriteLine(c.GetType());
    Console.WriteLine(d.GetType());
    Console.WriteLine(e.GetType());
    Console.WriteLine();
    Console.WriteLine();
}

// 8-2. typeof 연산자
{
    Console.WriteLine(typeof(Int32));
    Console.WriteLine(typeof(String));
    Console.WriteLine(typeof(Double));
    Console.WriteLine();
    Console.WriteLine();
}

// 8-3. GetType()과 typeof() 비교
{
    CodingPractice.Q8_3.Point p = new CodingPractice.Q8_3.Point(4, 5);
    Console.WriteLine(p.GetType().Name);
    Console.WriteLine(typeof(Point).Name);
    Console.WriteLine(p.GetType() == typeof(Point));
    Console.WriteLine(p.X.GetType().Name);
    Console.WriteLine(p.X.GetType());
    Console.WriteLine();
    Console.WriteLine();
}

// 9-1 기본 동작
{
    int a = 10;
    double b = 20;
    bool c = false;

    Console.WriteLine($"{a.ToString()}");
    Console.WriteLine($"{b.ToString()}");
    Console.WriteLine($"{c.ToString()}");
    Console.WriteLine();
    Console.WriteLine();
}

// 9-2. ToString() 메서드 재정의하기
{
    Panda panda = new Panda();
    panda.Name = "Petey";
    Console.WriteLine(panda.ToString());
    Console.WriteLine(panda);
    Console.WriteLine();
    Console.WriteLine();
}

// 9-3. 더 상세한 ToString() 구현
{
    Player p = new Player("Hero", 10, 100);
    Console.WriteLine(p);
    Console.WriteLine();
    Console.WriteLine();
}

// 10. object 클래스의 멤버들
{
    string s1 = "Hello";
    string s2 = "Hello";
    string s3 = "No";

    object obj1 = s1;
    object obj2 = s2;
    object obj3 = s3;

    Console.WriteLine($"s1.Equals(s2): {s1.Equals(s2): True}");
    Console.WriteLine($"ReferenceEquals(s1, s2): {ReferenceEquals(s1, s2): True}");
    Console.WriteLine($"ReferenceEquals(s1, s3): {ReferenceEquals(s1, s3): True}");
    Console.WriteLine($"obj1.Equals(obj2): {obj1.Equals(obj2)}");
    Console.WriteLine($"ReferenceEquals(obj1, obj2) {ReferenceEquals(obj1, obj2)}");
    Console.WriteLine($"ReferenceEquals(obj1, obj3) {ReferenceEquals(obj1, obj3)}");

    Console.WriteLine();
    Console.WriteLine();
}