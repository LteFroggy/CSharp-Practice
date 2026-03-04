using System;

class Say {
    public Say() {
        Console.WriteLine($"[1] 안녕하세요.");
    }

    public Say(string message) : this() {
        Console.WriteLine(message);
    }
}