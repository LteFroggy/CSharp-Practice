using System;

class Seat {
    private static int _usedCount;
    private static int _personCount;
    private int _seatNum;
    private string _name;

    public Seat(string name) {
        _name = name;
        _personCount++;
        _usedCount++;
        _seatNum = _usedCount;
        Console.WriteLine($"좌석 {_seatNum}번 착석 : {_name}");
    }

    public void Study() {
        Console.WriteLine($"{_name}이(가) 좌석 {_seatNum}번에서 공부 중...");
    }

    public static void ShowStatus() {
        Console.WriteLine($"총 이용 : {_usedCount}명, 현재 착석 {_personCount}명");
    }
    ~Seat() {
        _personCount--;
        Console.WriteLine($"좌석 {_seatNum}번 반납 : {_name}");
    }
}