using System;
using static System.Console;
using static System.Math;

// 1. 정규화된 이름으로 네임스페이스 사용
{
    Foo.Car car1 = new Foo.Car();
    Bar.Car car2 = new Bar.Car();
    Console.WriteLine();
    Console.WriteLine();
}

// 2. 중첩 네임스페이스 활용
{
    Korea.Seoul.Car car1 = new Korea.Seoul.Car();
    Korea.Incheon.Car car2 = new Korea.Incheon.Car();
    car1.Run();
    car2.Run();
    Console.WriteLine();
    Console.WriteLine();
}

// 3. using static 지시문
{
    WriteLine("Hello, World!");
    WriteLine($"제곱근 : {Sqrt(16)}");
    WriteLine($"최댓값 : {Max(15, 20)}");
    Console.WriteLine();
    Console.WriteLine();
}