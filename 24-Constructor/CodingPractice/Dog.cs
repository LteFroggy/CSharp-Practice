using System;
using System.Runtime.CompilerServices;

class Dog {
    private string _name;
    public Dog () { }
    public Dog(string name) {
        _name = name;
    }
    
    public string Name { get; set;}
    public void Cry() {
        Console.WriteLine($"{_name}이(가) 멍멍멍");
    }

}