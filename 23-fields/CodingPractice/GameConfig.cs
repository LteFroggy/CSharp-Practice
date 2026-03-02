using System;

class GameConfig {
    public readonly string version = "1.0.0";
    public readonly int maxPlayers;
    public GameConfig() {
        maxPlayers = 4;
    }

    public void ShowStatus() {
        Console.WriteLine($"버전 : {version}");
        Console.WriteLine($"최대 플레이어 : {maxPlayers}");
    }
}