using System;
class GreetingClass {
    public static string CreateGreeting(string name, string greeting = "안녕하세요", string time = "아침") {
        return $"[{time}] {greeting}, {name}님!";
    }
}