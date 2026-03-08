// 메인 코드
using System;

Run();

GC.Collect();
GC.WaitForPendingFinalizers();
Console.WriteLine("=== 정리 완료 ===");

static void Run() {
    Console.WriteLine("=== 아이템 생성 ===");
    GameItem potion = new GameItem("체력 포션", 50);
    GameItem sword = new GameItem("강철 검", 200);
    GameItem shield = new GameItem("나무 방패", 100);

    Console.WriteLine();
    Console.WriteLine("=== 아이템 사용 ===");
    potion.Use();
    sword.Use();

    Console.WriteLine();
    Console.WriteLine("=== 인벤토리 정리 ===");
    potion = null;
    sword = null;
    shield = null;
}

class GameItem {
    private static int s_nextId = 1;
    private int _id;
    private string _name;
    private int _price;

    public GameItem(string name, int price) {
        _id = s_nextId++;
        _name = name;
        _price = price;
        Console.WriteLine($"[생성] 아이템 #{_id}: {_name} ({_price}골드)");
    }

    public void Use() {
        Console.WriteLine($"[사용] {_name} 아이템을 사용함");
    }

    ~GameItem() {
        Console.WriteLine($"[삭제] 아이템 #{_id}: {_name} 인벤토리에서 제거됨");
    }
}