using System;
using System.Collections.Generic;
using System.Text;
class Player {
    private string _name;
    private int _health;

    public void ShowStatus() {
        Console.WriteLine($"이름 : {_name}");
        Console.WriteLine($"체력 : {_health}");
    }
}