using System;

class Dog {
    private string _name;
    private int _age;

    public Dog(string name, int age) {
        _name = name;
        _age = age;
    }

    public void Bark() {
        Console.WriteLine($"{_name} : 멍멍!");
    }

    public void PrintInfo() {
        Console.WriteLine($"이름 : {_name}, 나이 : {_age}살");
    }
}