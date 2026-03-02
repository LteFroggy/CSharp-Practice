using System;
class Example {
    public const double Pi = 3.14159;
    public readonly DateTime createdAt = DateTime.Now;
    public void ShowValues() {
        Console.WriteLine($"원주율 : {Pi}");
        Console.WriteLine($"생성 시간 :{createdAt}");
    }
}