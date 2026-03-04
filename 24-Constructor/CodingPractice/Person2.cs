using System;

class Person2 {
    private string _name = "홍길동";
    private int _age = 21;

    public Person2() {
        Console.WriteLine($"이름 : {_name}, 나이 : {_age}");
    }

    public Person2(string name) {
        _name = name;
        Console.WriteLine($"이름 : {_name}, 나이 : {_age}");
    }

    public Person2(string name, int age) {
        _name = name;
        _age = age;
        Console.WriteLine($"이름 : {_name}, 나이 : {_age}");
    }
}