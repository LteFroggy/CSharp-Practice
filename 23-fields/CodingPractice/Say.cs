using System;

class Say {
    private string _message = "안녕하세요";

    public void Hi() {
        _message = "반갑습니다";
        Console.WriteLine($"{_message}");
    }
}