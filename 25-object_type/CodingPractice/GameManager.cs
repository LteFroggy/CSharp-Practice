using System;

class GameManager {
    public GameManager() {
        _playerName = "홍길동";
    }

    private static int _totalPlayers = 10;
    public static void ShowStatus() {
        Console.WriteLine($"[정적] 총 플레이어 수 : {_totalPlayers}");
    }
    
    private string _playerName;
    public void Greet() {
        Console.WriteLine($"[인스턴스] 안녕하세요, {_playerName}님!");
    }
}