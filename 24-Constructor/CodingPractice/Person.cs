using System;

class Person {
    private string _name;
    private int _age;
    public Person() {
        _name = "홍길동";
        Console.WriteLine($"생성자가 호출되었습니다.");
    }

    public Person(string _name, int _age) {
        this._name = _name;
        this._age = _age;
    }
    
    public string GetName { get => _name; }
    public void PrintInfo() {
        Console.WriteLine($"이름 : {_name}, 나이 : {_age}");
    }
}