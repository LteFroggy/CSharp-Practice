using System;

class Person3 {
    private static string _name;
    private int _age;

    static Person3() {
        _name = "홍길동";
        Console.WriteLine($"정적 생성자 호출됨");
    }

    public Person3(int age) {
        _age = age;
        Console.WriteLine($"나이 : {_age}");
    }

    public static void ShowName() {
        Console.WriteLine($"이름 : {_name}");
    }
}