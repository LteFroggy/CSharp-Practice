using System;

class Person {
    private string _name = "홍길동";
    private const int k_Age = 21;
    private readonly string _nickname = "길동이";
    private string[] sites = { "네이버", "구글" };

    public void ShowProfile() {
        Console.WriteLine($"이름 : {_name}");
        Console.WriteLine($"이름 : {k_Age}");
        Console.WriteLine($"이름 : {_nickname}");
        foreach (string str in sites) {
            Console.Write($"{str} ");
        }
    }
}